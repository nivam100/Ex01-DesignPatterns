using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    class FriendFilter
    {
        public User m_user { get; set; }
        
        public IEnumerable<User> Filter(Func<User, bool> i_filter)
        {
            foreach (User friend in m_user.Friends)
            {
                if (i_filter(friend))
                {
                    yield return friend;
                }
            }
        }

        public IEnumerable<User> ChainFilter(ITestHandler<User> i_filter)
        {
            foreach (User friend in m_user.Friends)
            {
                if (i_filter.execute(friend))
                {
                    yield return friend;
                }
            }
        }


        public bool GenderFilter(User i_user, User.eGender i_gender)
        {
            return i_gender == i_user.Gender;
        }

        public bool GenderFemale(User i_user)
        {
            return GenderFilter(i_user, User.eGender.female);
        }

        public bool GenderMale(User i_user)
        {
            return GenderFilter(i_user, User.eGender.male);
        }

        public bool Single(User i_user, bool i_force)
        {
            bool ans = false;
            if (i_user.RelationshipStatus != null)
            {
                ans = User.eRelationshipStatus.Married != i_user.RelationshipStatus;
            }
            else if (i_force)
            {
                ans = false;
            }
            else
            {
                ans = false;
            }
            return ans;
                
        }

        public bool AgeFilter(User i_user, DateTime i_beforeDate, DateTime i_afterDate, bool i_force = false)
        {
            if (i_user.Birthday != null)
            {
                DateTime birthday = Convert.ToDateTime(i_user.Birthday);
                if (birthday <= i_beforeDate && birthday >= i_afterDate)
                {
                    return true;
                }
            }
            else
            {
                return !i_force;
            }

            return false;
        }

       
        
    }
}
