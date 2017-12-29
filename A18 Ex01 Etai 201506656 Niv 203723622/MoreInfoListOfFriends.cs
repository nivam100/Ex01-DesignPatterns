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
        public Form2 m_MoreInfoForm;

        

        public MoreInfoListOfFriends(object facebookObj) : base(facebookObj)
        {
            this.m_Friend = facebookObj as User;
            m_ListForListBox = new List<string>();
            this.m_MoreInfoForm = new Form2();
            this.CreateMoreInfoText();
            this.CreateMoreInfoForm();
        }

        public override void CreateMoreInfoText()
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
           
        }

        public override void CreateMoreInfoForm()
        {
            foreach (string str in m_ListForListBox)
            {
                m_MoreInfoForm.more.Items.Add(str);
            }
        }
    }
}

