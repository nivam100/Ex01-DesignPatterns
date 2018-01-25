using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    public class LoginButtonConcreteObserver : Button, IObserver
    {
        public LoginButtonConcreteObserver()
        {
            this.Enabled = false; 
        }

        public void UpdateState()
        {
            this.Enabled = true; 
        }
    }
}
