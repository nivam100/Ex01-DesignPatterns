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
    public partial class MoreInfoEvent : Form
    {
        private Event m_event; 

        public Event EventDataSource
        {
            get { return m_event; }
            set { m_event = value;
                eventBindingSource.DataSource = value;
            }
        }
        public MoreInfoEvent()
        {
            InitializeComponent();
        }
    }
}
