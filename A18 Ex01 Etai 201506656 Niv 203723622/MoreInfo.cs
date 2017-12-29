using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    public abstract class MoreInfo
    {
        protected MoreInfo(object facebookObj) { }

        public abstract void CreateMoreInfoText();

        public abstract void CreateMoreInfoForm();

    }
}
