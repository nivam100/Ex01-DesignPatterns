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
        Event m_Event;
        List<string> m_ListForListBox;

        public MoreInfoListOfEvents(object facebookObj) : base(facebookObj)
        {
            this.m_Event = facebookObj as Event;
            m_ListForListBox = new List<string>();
        }

        public override List<string> CreateMoreInfoText()
        {
            m_ListForListBox.Add("Name Of The Event:");
            m_ListForListBox.Add(Environment.NewLine);
            m_ListForListBox.Add(m_Event.Name);
            m_ListForListBox.Add(Environment.NewLine);
            m_ListForListBox.Add("Owner of the event:");
            m_ListForListBox.Add(Environment.NewLine);
            m_ListForListBox.Add(m_Event.Owner.FirstName + " " + m_Event.Owner.LastName);
            m_ListForListBox.Add(Environment.NewLine);
            m_ListForListBox.Add("The Event Will Start at:");
            m_ListForListBox.Add(Environment.NewLine);
            m_ListForListBox.Add(m_Event.StartTime.ToString());
            m_ListForListBox.Add(Environment.NewLine);
            if(m_Event.Location != null)
            {
                m_ListForListBox.Add("The Event Will Take Place at:");
                m_ListForListBox.Add(Environment.NewLine);
                m_ListForListBox.Add(m_Event.Location);
            }
            return m_ListForListBox;
        }
    }
}
