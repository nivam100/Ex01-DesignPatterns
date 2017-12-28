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
        Post m_Post;
        List<string> m_ListForListBox; 
    
        public MoreInfoPostsAndLikes(object facebookObj) : base(facebookObj)
        {
            this.m_Post = facebookObj as Post;
            m_ListForListBox = new List<string>();
        }

        public override List<string> CreateMoreInfoText()
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
            return m_ListForListBox;
        }
    }
}
