﻿using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    public partial class Form1 : Form
    {
        private User m_LoggedInUser;
        private User m_UserTest;
        private string m_AppID;

        private enum eNoun1
        {
            Brown_Eyes,
            Bus_Driver,
            Really_tough_guy,
            Wheed_Lover,
            Pole_Stripper,
            Drug_Addict,
            Lazy_Dog
        }

        private enum eNoun2
        {
            Hairy,
            Pervert,
            Sexy,
            Nasty,
            Bearded,
            Snoring,
            Shaky
        }

        private enum eMember
        {
            Friend,
            Partner,
            Boss,
            Teacher,
            Grandmother,
            Girlfriend,
            Brother,
            Sister,
            Mom
        }

        private enum eProffession
        {
            Entrepreneur,
            Coder,
            Waiter,
            Trader,
            Fighter,
            Pilot,
            Wrestler,
            Chef,
            Player,
            Translator
        }

        public Form1()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            LoginAndInit();
        }

        private void LoginAndInit()
        {
            /// Owner: design.patterns

            if(m_AppID != null)
            {
                LoginResult result = FacebookService.Login("1450160541956417", /// (design patterrns Ex01 app)     //"124318548263284"
                "public_profile",
                "user_education_history",
                "user_birthday",
                "user_actions.video",
                "user_actions.news",
                "user_actions.music",
                "user_actions.fitness",
                "user_actions.books",
                "user_about_me",
                "user_friends",
                "publish_actions",
                "user_events",
                "user_games_activity",
                //"user_groups" (This permission is only available for apps using Graph API version v2.3 or older.)
                "user_hometown",
                "user_likes",
                "user_location",
                "user_managed_groups",
                "user_photos",
                "user_posts",
                "user_relationships",
                "user_relationship_details",
                "user_religion_politics",

                //"user_status" (This permission is only available for apps using Graph API version v2.3 or older.)
                "user_tagged_places",
                "user_videos",
                "user_website",
                "user_work_history",
                "read_custom_friendlists",

                // "read_mailbox", (This permission is only available for apps using Graph API version v2.3 or older.)
                "read_page_mailboxes",
                // "read_stream", (This permission is only available for apps using Graph API version v2.3 or older.)
                // "manage_notifications", (This permission is only available for apps using Graph API version v2.3 or older.)
                "manage_pages",
                "publish_pages",
                "publish_actions",

                "rsvp_event"
                );

                if (!string.IsNullOrEmpty(result.AccessToken))
                {
                    m_LoggedInUser = result.LoggedInUser;
                    FetchUserInfo();
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage);
                }
            } else
            {
                MessageBox.Show("Please check App ID");
            }
            /// Use the FacebookService.Login method to display the login form to any user who wish to use this application.
            /// You can then save the result.AccessToken for future auto-connect to this user:
           
        }

        private void FetchUserInfo()
        {
            string FirstAndLastname = String.Format("{0} {1}", this.m_LoggedInUser.FirstName, m_LoggedInUser.LastName);
            this.labelUsername.Text = FirstAndLastname;
            this.pictureBoxProfile.ImageLocation = this.m_LoggedInUser.PictureSmallURL;
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            Action logoutMessage = OnSuccessfullLogout;
            FacebookService.Logout(logoutMessage);
        }

        private static void OnSuccessfullLogout()
        {
            MessageBox.Show("Successfull Logout");
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            LoginAndInit();
        }

        private void ButtonPost_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBoxPostText.Text))
            {
                Status postedStatus = m_LoggedInUser.PostStatus(textBoxPostText.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            } else
            {
                textBoxPostText.Text = "You must post some text!";
            }
        }


        private void FetchPosts()
        {
            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    postsAndLikes.Items.Add(post.Message); 
                }
                else if (post.Caption != null)
                {
                    postsAndLikes.Items.Add(post.Caption);
                }
                else
                {
                    postsAndLikes.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (m_LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void FetchFriends(bool i_CheckBirthday)
        {
            lsitOfFriends.Items.Clear();
            lsitOfFriends.DisplayMember = "Name";
            int counter = 0;
            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (!i_CheckBirthday)
                {
                    lsitOfFriends.Items.Add(friend);
                }
                else
                {
                    try
                    {
                        friendsBirthdays.Items.Add(friend.FirstName + " " + friend.LastName + ": " + friend.Birthday.ToString());
                        counter++;
                    }
                    catch (Exception e)
                    {

                    }
                }
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if(counter == 0 && i_CheckBirthday)
            {
                MessageBox.Show("No Birthdays to retrieve :(");
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        private void FetchEvents()
        {
            ListOfEvents.Items.Clear();
            ListOfEvents.DisplayMember = "Name";
            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                ListOfEvents.Items.Add(fbEvent);
            }

            if (m_LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        private void FetchPages()
        {
            pages.Items.Clear();
            pages.DisplayMember = "Name";
        
            foreach (Page page in m_LoggedInUser.LikedPages)
            {
                pages.Items.Add(page);
            }

            if (m_LoggedInUser.LikedPages.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :(");
            }
        }

        private void CreateRandomPost()
        {
            string noun1 = Enum.GetName(typeof (eNoun1), Convert.ToInt32((new Random()).NextDouble() * Enum.GetNames(typeof(eNoun1)).Length));
            string noun2 = Enum.GetName(typeof(eNoun2), Convert.ToInt32((new Random()).NextDouble() * Enum.GetNames(typeof(eNoun2)).Length));
            string member = Enum.GetName(typeof(eMember), Convert.ToInt32((new Random()).NextDouble() * Enum.GetNames(typeof(eMember)).Length));
            string profession = Enum.GetName(typeof(eProffession), Convert.ToInt32((new Random()).NextDouble() * Enum.GetNames(typeof(eProffession)).Length));
            string randomPost = "my " + member + " is a " + noun1.Replace("_", " ") + " " + noun2 + " " + profession;
            Status postedStatus = m_LoggedInUser.PostStatus(randomPost);
            MessageBox.Show("Status Posted! ID: " + postedStatus.Id + "the post is: " + randomPost);
        }
        
        private void ButtonFetchPosts_Click(object sender, EventArgs e)
        {
            FetchPosts();
        }

        private void PostsAndLikes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonFetchFriends_Click(object sender, EventArgs e)
        {
            FetchFriends(false);
        }

        private void ListOfFriends_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonFetchLikedEvents_Click(object sender, EventArgs e)
        {
            FetchEvents();
        }

        private void ButtonFetchPages_Click(object sender, EventArgs e)
        {
            FetchPages();
        }

        private void ButtonCreateRandomPost_Click(object sender, EventArgs e)
        {
            CreateRandomPost();
        }

        private void ButtonGetBirthdays_Click(object sender, EventArgs e)
        {
            FetchFriends(true);
        }

        private void ClassAppId_CheckedChanged(object sender, EventArgs e)
        {
            m_AppID = "1450160541956417";
        }

        private void OurAppId_CheckedChanged(object sender, EventArgs e)
        {
            m_AppID = "124318548263284";
        }
    }
}
