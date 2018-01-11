using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    class ConcreteSubjectRadioButton : RadioButtonSubject
    {
        private bool StateChanged { get; set; }
       
        public ConcreteSubjectRadioButton()
        {
            this.CheckedChanged += new System.EventHandler(this.ChangeState);
        }

        private void ChangeState(object sender, EventArgs e)
        {
            StateChanged = true;
            Notify();
        }
    }
}
