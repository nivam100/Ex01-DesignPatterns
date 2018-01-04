using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    public static class MoreInfoFactory
    {
        public static IMoreInfoBuilder CreateMoreInfoWindow(object facebookObj)
        {
            if (facebookObj as Post != null)
            {
                return new MoreInfoPostsAndLikes(facebookObj);
            }
            else if(facebookObj as User != null)
            {
                return new MoreInfoListOfFriends(facebookObj);
            }
            else if (facebookObj as Event != null)
            {
                return new MoreInfoListOfEvents(facebookObj);
            }
            
            else return null; 
        }

        internal static Form CreateMoreInfoWindow(object i_selectedItem, string i_type)
        {
            Form returnVal = null;
            switch (i_type)
            {
                case "event":
                    returnVal = MoreInfoListOfEvents.Create(i_selectedItem);
                    break;
                case "post":
                    returnVal = MoreInfoPostsAndLikes.Create(i_selectedItem);
                    break;
                case "friend":
                    returnVal = MoreInfoListOfFriends.Create(i_selectedItem);
                    break;
            }
            return returnVal;
        }
    }
}
