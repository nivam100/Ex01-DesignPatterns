using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    public class MatchFinder
    {
        private FriendFilter m_logic;

        internal MatchFinder(User i_user) 
        {
            m_logic = new FriendFilter { m_user = i_user };
        }
        
        public IEnumerable<User> MatchWithAge(User.eGender i_gender, string i_single = "false", int i_minAge = 18, int i_maxAge = 70)
        {
            DateTime bornBefore = DateTime.Now.AddYears(-i_minAge);
            DateTime bornAfter = DateTime.Now.AddYears(-i_maxAge);
            bool forceSingle = false;
            bool single = false;
            switch (i_single)
            {
                case "false":
                    single = false;
                    break;
                case "true":
                    single = true;
                    break;
                case "force":
                    single = true;
                    forceSingle = true;
                    break;
            }

            UserTest headTest = new UserTest((i_user) => m_logic.GenderFilter(i_user, i_gender));
            headTest.Add((i_user) => m_logic.AgeFilter(i_user, bornBefore, bornAfter));
            headTest.Add((i_user) => single ? m_logic.Single(i_user, forceSingle) : true);
            return m_logic.ChainFilter(headTest);
        }

        public IEnumerable<User> Match(User.eGender i_gender, string i_single = "False")
        {
            bool single = false;
            switch (i_single)
            {
                case "False":
                    single = false;
                    break;
                case "True":
                    single = true;
                    break;
                case "Force":
                    single = true;
                    break;
            }

            ITestHandler<User> tester = new UserTest((i_user) => m_logic.GenderFilter(i_user, i_gender));
            tester.Add((i_user) => single ? m_logic.GenderFilter(i_user, i_gender) : true);
            return m_logic.ChainFilter(tester);
        }

        /// <summary>
        /// Tester that checks if user is in legal age (18 years of age) 
        /// </summary>
        /// <param name="i_user"></param>
        /// <returns>Is the user of legal age</returns>
        public bool LegalAge(User i_user)
        {
            DateTime minAge = DateTime.Now.AddYears(-18);
            return m_logic.AgeFilter(i_user, minAge, DateTime.Now, i_force: true);
        }

        public int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
            {
                age = age - 1;
            }

            return age;
        }
    }
}
