using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    public partial class Form1 : Form
    {
        private User m_loggedInUser;
        private string m_appID;
        Menu m_Menu;

        private enum Actions
        {
            FetchPosts = 0,
            FetchFriends = 1,
            FetchEvents = 2,
            FetchPages = 3
        }
        

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

        Actions m_Action;

        public Form1()
        {
            InitMenu();
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
        }

        public void InitMenu()
        {
            m_Menu = new Menu
            {
                new MenuItem{ Command = this.doFetchPosts },
                new MenuItem{ Command = this.doFetchFriends },
                new MenuItem{ Command = this.doFetchEvents },
                new MenuItem{ Command = this.doFetchPages }
            };
        }

        

        private void LoginAndInit()
        {
            SocialNetworkDirector facebookConnector = new SocialNetworkDirector();
            m_loggedInUser = facebookConnector.LoginAndGetUser(m_appID, new FaceBookBuilder());
            if (m_loggedInUser != null)
            {
                FetchUserInfo();
            }
            else
            {
                MessageBox.Show("Check App ID and StdEror");
            }
        }

        private void FetchUserInfo()
        {
            new Thread(() => this.pictureBoxProfile.ImageLocation = this.m_loggedInUser.PictureSmallURL).Start();
            string firstAndLastname = String.Format("{0} {1}", this.m_loggedInUser.FirstName, m_loggedInUser.LastName);
            this.labelUsername.Text = firstAndLastname;
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
                Status postedStatus = m_loggedInUser.PostStatus(textBoxPostText.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            } else
            {
                textBoxPostText.Text = "You must post some text!";
            }
        }

        private void FetchPosts()
        {
            Invoke(new Action(() => postBindingSource.DataSource = m_loggedInUser.Posts));
        }

        private void FetchFriends(bool i_CheckBirthday)
        {
            Invoke(new Action(() => userBindingSource.DataSource = m_loggedInUser.Friends));
        }

        private void FetchEvents()
        {
            Invoke(new Action(() => eventBindingSource.DataSource = m_loggedInUser.Events));
        }

        private void FetchPages()
        {
            Invoke(new Action(() => pageBindingSource.DataSource = m_loggedInUser.LikedPages));
        }

        private void CreateRandomPost()
        {
            string noun1 = Enum.GetName(typeof(eNoun1), Convert.ToInt32((new Random()).NextDouble() * Enum.GetNames(typeof(eNoun1)).Length));
            string noun2 = Enum.GetName(typeof(eNoun2), Convert.ToInt32((new Random()).NextDouble() * Enum.GetNames(typeof(eNoun2)).Length));
            string member = Enum.GetName(typeof(eMember), Convert.ToInt32((new Random()).NextDouble() * Enum.GetNames(typeof(eMember)).Length));
            string profession = Enum.GetName(typeof(eProffession), Convert.ToInt32((new Random()).NextDouble() * Enum.GetNames(typeof(eProffession)).Length));
            string randomPost = "my " + member + " is a " + noun1.Replace("_", " ") + " " + noun2 + " " + profession;
            Status postedStatus = m_loggedInUser.PostStatus(randomPost);
            MessageBox.Show("Status Posted! ID: " + postedStatus.Id + "the post is: " + randomPost);
        }
        
        private void ButtonFetchPosts_Click(object sender, EventArgs e)
        {
            
            postBindingSource.DataSource = m_loggedInUser.Events;
            m_Action = Actions.FetchPosts;
            m_Menu.Run((int)m_Action);
            
        }

        private void doFetchPosts()
        {
            new Thread(FetchPosts).Start();
        }

        private void ButtonFetchFriends_Click(object sender, EventArgs e)
        {
            m_Action = Actions.FetchFriends;
            m_Menu.Run((int)m_Action); 
        }

        private void doFetchFriends()
        {
            new Thread(() => FetchFriends(false)).Start();
        }

        private void ListOfFriends_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ButtonFetchLikedEvents_Click(object sender, EventArgs e)
        {
            m_Action = Actions.FetchEvents;
            m_Menu.Run((int)m_Action);
        }

        private void doFetchEvents()
        {
            new Thread(FetchEvents).Start();
        }

        private void ButtonFetchPages_Click(object sender, EventArgs e)
        {
            m_Action = Actions.FetchPages;
            m_Menu.Run((int)m_Action);
        }

        private void doFetchPages()
        {
            new Thread(FetchPages).Start();
        }

        private void ButtonCreateRandomPost_Click(object sender, EventArgs e)
        {
            CreateRandomPost();
        }

        private void ButtonGetBirthdays_Click(object sender, EventArgs e)
        {
            new Thread(() => FetchFriends(true)).Start();
        }

        private void ClassAppId_CheckedChanged(object sender, EventArgs e)
        {
            m_appID = "1450160541956417";
        }

        private void OurAppId_CheckedChanged(object sender, EventArgs e)
        {
            m_appID = "124318548263284";
        }

        private void postsAndLikes_DoubleClick(object sender, EventArgs e)
        {
            MoreInfoPostsAndLikes moreInfo = MoreInfoFactory.CreateMoreInfoWindow(postsAndLikes.SelectedItem) as MoreInfoPostsAndLikes;
            moreInfo.m_MoreInfoForm.ShowDialog();
        }

        private void listOfFriends_DoubleClick(object sender, EventArgs e)
        {
            MoreInfoListOfFriends moreInfo = MoreInfoFactory.CreateMoreInfoWindow(listOfFriends.SelectedItem) as MoreInfoListOfFriends;
            moreInfo.m_MoreInfoForm.ShowDialog();
        }

        private void ListOfEvents_DoubleClick(object sender, EventArgs e)
        {
            MoreInfoListOfEvents moreInfo = MoreInfoFactory.CreateMoreInfoWindow(ListOfEvents.SelectedItem) as MoreInfoListOfEvents;
            moreInfo.m_MoreInfoForm.ShowDialog();
        }

        private void buttonRefreshAll_Click(object sender, EventArgs e)
        {
            new Thread(FetchEvents).Start();
            new Thread(() => FetchFriends(false)).Start();
            new Thread(FetchPages).Start();
            new Thread(FetchPosts).Start();

        }

        private void buttonFindMatch_Click(object sender, EventArgs e)
        {
            MatchFinderForm matchFinder = new MatchFinderForm(m_loggedInUser);
            matchFinder.ShowDialog();
        }

    }
}
