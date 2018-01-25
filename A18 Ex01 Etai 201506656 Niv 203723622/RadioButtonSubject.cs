using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    internal class RadioButtonSubject : RadioButton
    {
        private List<IObserver> m_Observers = new List<IObserver>();

        public void Attach(IObserver i_Observer)
        {
            m_Observers.Add(i_Observer);
        }

        public void Detach(IObserver i_Observer)
        {
            m_Observers.Remove(i_Observer);
        }

        public void Notify()
        {
            foreach(IObserver observer in m_Observers)
            {
                observer.UpdateState();
            }
        }
    }
}
