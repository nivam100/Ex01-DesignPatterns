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
    public partial class MatchFinderForm : Form
    {
        private User m_loggedInUser;
        public MatchFinderForm(User i_LoggedInUser)
        {
            m_loggedInUser = i_LoggedInUser;
            InitializeComponent();
            comboBoxGender.DataSource = Enum.GetValues(typeof(User.eGender));
        }

        private void buttonSearchMatch_Click(object sender, EventArgs e)
        {
            listBoxMatches.Items.Clear();
            new Thread(getMatches).Start();
        }

        private void getMatches()
        {
            listBoxMatches.Invoke(new Action(() => listBoxMatches.DisplayMember = "Name"));
            foreach (User friend in m_loggedInUser.Friends)
            {
                if (friend.Gender == (User.eGender)comboBoxGender.Invoke(new Func<User.eGender>(() => {return (User.eGender)comboBoxGender.SelectedItem; })))
                {
                    bool onlySingles = (bool)checkBoxSinglesOnly.Invoke(new Func<bool>(() => { return checkBoxSinglesOnly.Checked; }));
                    if(!onlySingles || friend.RelationshipStatus != User.eRelationshipStatus.Married)
                    {
                        listBoxMatches.Invoke(new Action(() => listBoxMatches.Items.Add(friend)));
                    }
                }
            }
        }

        private void listBoxMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            userBindingSource.DataSource = listBoxMatches.SelectedItem;
        }
    }
}
