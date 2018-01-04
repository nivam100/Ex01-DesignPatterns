using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    public interface IMoreInfoBuilder
    {
        //public IMoreInfo(object facebookObj) { }
        Form Create(object i_selectedItem);
        
        // TODO 
        //public abstract void CreateMoreInfoText();

        //public abstract void CreateMoreInfoForm();

    }

    public class MoreInfoEventBuilder : IMoreInfoBuilder
    {
        public Form Create(object i_selectedItem)
        {
            MoreInfoEvent retForm = new MoreInfoEvent();
            retForm.EventDataSource = i_selectedItem as Event;
            return retForm;
        }
    }
}
