using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    public class MoreInfoPostsAndLikes : IMoreInfoBuilder
    {
        Post m_Post;
        List<string> m_ListForListBox;
        public Form2 m_MoreInfoForm;

        

        public MoreInfoPostsAndLikes(object facebookObj) : base(facebookObj)
        {
            this.m_Post = facebookObj as Post;
            this.m_MoreInfoForm = new Form2();
            m_ListForListBox = new List<string>();
            this.CreateMoreInfoText();
            this.CreateMoreInfoForm();
        }

        public override void CreateMoreInfoText()
        {
            bool beenHere = false;
            m_ListForListBox.Add("Date and time of the post:");
            m_ListForListBox.Add(Environment.NewLine);
            m_ListForListBox.Add(m_Post.CreatedTime.ToString());
            m_ListForListBox.Add(Environment.NewLine);
            m_ListForListBox.Add("The Messege is:");
            m_ListForListBox.Add(Environment.NewLine);
            m_ListForListBox.Add(m_Post.Message.ToString());
            m_ListForListBox.Add(Environment.NewLine);
            m_ListForListBox.Add("The comments are:");
            m_ListForListBox.Add(Environment.NewLine);
            foreach (Comment comment in m_Post.Comments)
            {
                beenHere = true; 
                m_ListForListBox.Add(comment.Message);
                m_ListForListBox.Add(Environment.NewLine);
            }
            if(beenHere == false)
            {
                m_ListForListBox.Add("No Comments");
            }
            
        }

        internal static Form Create(object i_selectedItem)
        {
            throw new NotImplementedException();
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
