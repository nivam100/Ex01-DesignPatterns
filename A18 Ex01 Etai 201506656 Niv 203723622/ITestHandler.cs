using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    interface ITestHandler<T>
    {
        bool execute(T i_input);
        void add(Func<T,bool> i_input);
    }

    public class TestHandler : ITestHandler<User>
    {
        private ITestHandler<User> m_nextHandler;
        private Func<User, bool> m_test;

        public TestHandler(Func<User, bool> i_input)
        {
            this.m_test = i_input;
        }

        public void add(Func<User, bool> i_input)
        {
            if(m_nextHandler == null)
            {
                m_nextHandler = new TestHandler(i_input);
            }
            else
            {
                m_nextHandler.add(i_input);
            }
        }

        public bool execute(User i_input)
        {
            bool retVal = m_test(i_input);
            if (m_nextHandler != null)
            {
                retVal = retVal ? m_nextHandler.execute(i_input) : false;
            }

            return retVal;
        }

       
    }
}
