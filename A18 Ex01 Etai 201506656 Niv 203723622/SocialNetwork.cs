using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    public class SocialNetworkDirector
    {
        public User LoginAndGetUser(string i_appID, ISocialNetworkBuilder i_builder)
        {
            bool loggedIn = i_builder.Login(i_appID);
            return loggedIn ? i_builder.LoggedUser() : null;
        } 
    }

    public interface ISocialNetworkBuilder
    {
        bool Login(string i_appID);
        User LoggedUser();
    }

    public class FaceBookBuilder : ISocialNetworkBuilder
    {
        private User m_loggedInUser;

        public User LoggedUser()
        {
            return this.m_loggedInUser;
        }

        public bool Login(string i_appID)
        {
            string appId = i_appID == string.Empty ? "1450160541956417" : i_appID;

            LoginResult loginResult = FacebookService.Login(appId, 
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
            if (!string.IsNullOrEmpty(loginResult.AccessToken))
            {
                m_loggedInUser = loginResult.LoggedInUser;
            }
            else
            {
                Console.Error.WriteLine(loginResult.ErrorMessage);
            }
            return m_loggedInUser != null;
        }
    }
}
    

