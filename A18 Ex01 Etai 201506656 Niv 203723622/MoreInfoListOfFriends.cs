using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;


namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    public class MoreInfoListOfFriends: MoreInfo
    {
        User m_Friend; 
        List<string> m_ListForListBox;

        public MoreInfoListOfFriends(object facebookObj) : base(facebookObj)
        {
            this.m_Friend = facebookObj as User;
            m_ListForListBox = new List<string>();
        }

        public override List<string> CreateMoreInfoText()
        {
            m_ListForListBox.Add("Friends name is:");
            m_ListForListBox.Add(Environment.NewLine);
            m_ListForListBox.Add(m_Friend.FirstName + " " + m_Friend.LastName);
            m_ListForListBox.Add(Environment.NewLine);
            m_ListForListBox.Add("Your Friend gender is:");
            m_ListForListBox.Add(Environment.NewLine);
            m_ListForListBox.Add(m_Friend.Gender.ToString());
            m_ListForListBox.Add(Environment.NewLine);
            m_ListForListBox.Add("Friend Time Zone:");
            m_ListForListBox.Add(Environment.NewLine);
            m_ListForListBox.Add(m_Friend.TimeZone.ToString());
            return m_ListForListBox;
        }
    }
}

