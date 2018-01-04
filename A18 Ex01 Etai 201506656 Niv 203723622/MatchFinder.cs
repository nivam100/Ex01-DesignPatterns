using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    public class MatchFinder
    {
        private FriendFilter m_logic;

        internal MatchFinder(User i_user) 
        {
            m_logic = new FriendFilter { m_user = i_user };
        }
        
        /// <summary>
        ///  i_single, recivies "false", "true" and "force" to force only matches with age.
        /// </summary>
        /// <param name="i_gender"></param>
        /// <param name="i_single"></param>
        /// <returns></returns>
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
            return m_logic.Filter((i_usr) => { bool a =  m_logic.GenderFilter(i_usr, i_gender) && m_logic.AgeFilter(i_usr, bornBefore, bornAfter);
                bool b = single ? m_logic.Single(i_usr, forceSingle) : true;
                return a && b;
            });
        }

        
        public IEnumerable<User> Match(User.eGender i_gender, string i_single = "False")
        {
            bool forceSingle = false;
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
                    forceSingle = true;
                    break;
            }
            return m_logic.Filter((i_usr) => {
                bool a = m_logic.GenderFilter(i_usr, i_gender);
                bool b = single ? m_logic.Single(i_usr, forceSingle) : true;
                return a && b;
            });
        }

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
                age = age - 1;

            return age;
        }
    }
}
