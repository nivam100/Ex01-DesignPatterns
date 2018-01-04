using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    public class MoreInfoPostsAndLikes : MoreInfo
    {
        public Form2 m_MoreInfoForm;
        private Post m_post;
        private List<string> m_listForListBox;

        public MoreInfoPostsAndLikes(object facebookObj) : base(facebookObj)
        {
            this.m_post = facebookObj as Post;
            this.m_MoreInfoForm = new Form2();
            m_listForListBox = new List<string>();
            this.CreateMoreInfoText();
            this.CreateMoreInfoForm();
        }

        public override void CreateMoreInfoText()
        {
            bool beenHere = false;
            m_listForListBox.Add("Date and time of the post:");
            m_listForListBox.Add(Environment.NewLine);
            m_listForListBox.Add(m_post.CreatedTime.ToString());
            m_listForListBox.Add(Environment.NewLine);
            m_listForListBox.Add("The Messege is:");
            m_listForListBox.Add(Environment.NewLine);
            m_listForListBox.Add(m_post.Message.ToString());
            m_listForListBox.Add(Environment.NewLine);
            m_listForListBox.Add("The comments are:");
            m_listForListBox.Add(Environment.NewLine);
            foreach (Comment comment in m_post.Comments)
            {
                beenHere = true; 
                m_listForListBox.Add(comment.Message);
                m_listForListBox.Add(Environment.NewLine);
            }
            if (beenHere == false)
            {
                m_listForListBox.Add("No Comments");
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
