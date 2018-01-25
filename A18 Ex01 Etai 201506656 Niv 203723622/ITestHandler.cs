using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    /// <summary>
    /// Interface for Chain of responsibility.
    /// Filter
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ITestHandler<T>
    {
        bool UserTestHandler(T i_input);

        void Add(Func<T, bool> i_input);
    }

    public class UserTest : ITestHandler<User>
    {
        private ITestHandler<User> m_nextHandler;
        private Func<User, bool> m_test;

        public UserTest(Func<User, bool> i_input)
        {
            this.m_test = i_input;
        }

        public void Add(Func<User, bool> i_input)
        {
            if(m_nextHandler == null)
            {
                m_nextHandler = new UserTest(i_input);
            }
            else
            {
                m_nextHandler.Add(i_input);
            }
        }

        public bool UserTestHandler(User i_input)
        {
            bool retVal = m_test(i_input);
            if (m_nextHandler != null)
            {
                retVal = retVal ? m_nextHandler.UserTestHandler(i_input) : false;
            }

            return retVal;
        }
    }
}
