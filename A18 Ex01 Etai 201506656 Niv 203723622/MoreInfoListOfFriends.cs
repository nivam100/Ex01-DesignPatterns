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
        public Form2 m_MoreInfoForm;
        private User m_friend; 
        private List<string> m_listForListBox;

        public MoreInfoListOfFriends(object facebookObj): base(facebookObj)
        {
            this.m_friend = facebookObj as User;
            m_listForListBox = new List<string>();
            this.m_MoreInfoForm = new Form2();
            this.CreateMoreInfoText();
            this.CreateMoreInfoForm();
        }

        public override void CreateMoreInfoText()
        {
            m_listForListBox.Add("Friends name is:");
            m_listForListBox.Add(Environment.NewLine);
            m_listForListBox.Add(m_friend.FirstName + " " + m_friend.LastName);
            m_listForListBox.Add(Environment.NewLine);
            m_listForListBox.Add("Your Friend gender is:");
            m_listForListBox.Add(Environment.NewLine);
            m_listForListBox.Add(m_friend.Gender.ToString());
            m_listForListBox.Add(Environment.NewLine);
            m_listForListBox.Add("Friend Time Zone:");
            m_listForListBox.Add(Environment.NewLine);
            m_listForListBox.Add(m_friend.TimeZone.ToString());
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