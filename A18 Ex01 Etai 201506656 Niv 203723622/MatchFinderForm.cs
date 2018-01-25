using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Etai_201506656_Niv_203723622
{
    public partial class MatchFinderForm : Form
    {
        private MatchFinder m_matchFinder;
        private User m_loggedInUser;

        public MatchFinderForm(User i_loggedInUser)
        {
            m_loggedInUser = i_loggedInUser;
            m_matchFinder = MatchFinderCtor.Instance(i_loggedInUser);
            InitializeComponent();
            comboBoxGender.DataSource = Enum.GetValues(typeof(User.eGender));
            listBoxMatches.DisplayMember = "Name";
        }

        private void buttonSearchMatch_Click(object sender, EventArgs e)
        {
            listBoxMatches.Items.Clear();
            User.eGender gender = (User.eGender)comboBoxGender.SelectedItem;
            bool single = (bool)checkBoxSinglesOnly.Checked;
            IEnumerable<User> matches = m_matchFinder.Match(gender, single.ToString());
            foreach (User friend in matches)
            {
                listBoxMatches.Items.Add(friend);
            }
        }

        private void listBoxMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            userBindingSource.DataSource = listBoxMatches.SelectedItem;
        }
    }
}
