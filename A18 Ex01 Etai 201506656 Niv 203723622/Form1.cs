using FacebookWrapper;
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
        public Form1()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            loginAndInit();
        }

        User m_LoggedInUser;
        
        enum eNoun1
        {
            Brown_Eyes,
            Bus_Driver,
            Really_tough_guy,
            Wheed_Lover,
            Stripper,
            Drug_Addict,
            Lazy_Dog
        }

        enum eNoun2
        {
            Hairy,
            Pervert,
            Sexy,
            Nasty,
            Bearded,
            Snoring,
            Shaky
        }

        enum eMember
        {
           Friend,
           Partner,
           Boss,
           Teacher,
           Grandmother,
           Girl_Friend,
           Brother,
           Sister,
           Mom
        }

        enum eProffession
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

        private void loginAndInit()
        {
            /// Owner: design.patterns

            /// Use the FacebookService.Login method to display the login form to any user who wish to use this application.
            /// You can then save the result.AccessToken for future auto-connect to this user:
            LoginResult result = FacebookService.Login("124318548263284", /// (design patterrns Ex01 app)
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
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void fetchUserInfo()
        {
            string FirstAndLastname = String.Format("{0} {1}", this.m_LoggedInUser.FirstName, m_LoggedInUser.LastName);
            this.labelUsername.Text = FirstAndLastname;
            this.pictureBoxProfile.ImageLocation = this.m_LoggedInUser.PictureSmallURL;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Action logoutMessage = OnSuccessfullLogout;
            FacebookService.Logout(logoutMessage);
        }

        private static void OnSuccessfullLogout()
        {
            MessageBox.Show("Successfull Logout");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void buttonPost_Click(object sender, EventArgs e)
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


        private void fetchPosts()
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

        private void FetchFriends()
        {
            lsitOfFriends.Items.Clear();
            lsitOfFriends.DisplayMember = "Name";
            foreach (User friend in m_LoggedInUser.Friends)
            {
                lsitOfFriends.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
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

        private void buttonInsertImagePost_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    //string text = File.ReadAllText(file);
                    //size = text.Length;
                    MessageBox.Show(file);
                }
                catch (Exception)
                {
                }
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
        

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            fetchPosts();
        }

        private void textBoxPostText_TextChanged(object sender, EventArgs e)
        {

        }

        private void postsAndLikes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            FetchFriends();
        }

        private void lsitOfFriends_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonFetchLikedEvents_Click(object sender, EventArgs e)
        {
            FetchEvents();
        }

        private void buttonFetchPages_Click(object sender, EventArgs e)
        {
            FetchPages();
        }

        private void buttonCreateRandomPost_Click(object sender, EventArgs e)
        {
            CreateRandomPost();
        }
    }
}
