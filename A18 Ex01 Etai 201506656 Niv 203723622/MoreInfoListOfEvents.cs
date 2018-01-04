using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    public class MoreInfoListOfEvents : MoreInfo
    {
        public Form2 m_MoreInfoForm;
        private Event m_event;
        private List<string> m_listForListBox;

        public MoreInfoListOfEvents(object facebookObj) : base(facebookObj)
        {
            this.m_event = facebookObj as Event;
            m_listForListBox = new List<string>();
            this.m_MoreInfoForm = new Form2();
            this.CreateMoreInfoText();
            this.CreateMoreInfoForm();
        }

        public override void CreateMoreInfoText()
        {
            m_listForListBox.Add("Name Of The Event:");
            m_listForListBox.Add(Environment.NewLine);
            m_listForListBox.Add(m_event.Name);
            m_listForListBox.Add(Environment.NewLine);
            m_listForListBox.Add("Owner of the event:");
            m_listForListBox.Add(Environment.NewLine);
            m_listForListBox.Add(m_event.Owner.FirstName + " " + m_event.Owner.LastName);
            m_listForListBox.Add(Environment.NewLine);
            m_listForListBox.Add("The Event Will Start at:");
            m_listForListBox.Add(Environment.NewLine);
            m_listForListBox.Add(m_event.StartTime.ToString());
            m_listForListBox.Add(Environment.NewLine);
            if (m_event.Location != null)
            {
                m_listForListBox.Add("The Event Will Take Place at:");
                m_listForListBox.Add(Environment.NewLine);
                m_listForListBox.Add(m_event.Location);
            }
         
        }

        public override void CreateMoreInfoForm()
        {
            foreach (string str in m_listForListBox)
            {
                m_MoreInfoForm.more.Items.Add(str);
            }
        }
    }
}
