using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    public static class MoreInfoFactory
    {
        public static MoreInfo CreateMoreInfoWindow(object facebookObj)
        {
            if (facebookObj as Post != null)
            {
                return new MoreInfoPostsAndLikes(facebookObj);
            }
            else if (facebookObj as User != null)
            {
                return new MoreInfoListOfFriends(facebookObj);
            }
            else if (facebookObj as Event != null)
            {
                return new MoreInfoListOfEvents(facebookObj);
            }
            else
            {
                return null;
            }
        }
    }
}
