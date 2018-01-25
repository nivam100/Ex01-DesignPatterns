using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    public class MatchFinderCtor
    {
        public static MatchFinder Instance(User i_user)
        {
            return new MatchFinder(i_user);
        }
    }
}
