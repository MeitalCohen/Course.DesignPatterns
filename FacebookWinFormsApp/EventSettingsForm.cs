using BasicFacebookFeatures.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class EventSettingsForm : Form
    {
        private readonly EventSettingsFilter r_EventSettingsFilter;
        public EventSettingsFilter EventSettingsFilter { get { return r_EventSettingsFilter; } }

        public EventSettingsForm(bool i_IsFBEventDisplayed, bool i_IsFriendsBirthdayDisplayed, List<FriendList> i_FriendsList)
        {
            r_EventSettingsFilter = new EventSettingsFilter()
            {
                FriendsLists = i_FriendsList,
                IsFBEventsDisplayed = i_IsFBEventDisplayed,
                IsFriendsBirthdayDisplayed = i_IsFriendsBirthdayDisplayed
            };

            InitializeComponent();

            loadData();
        }

        private void loadData()
        {
            chckBxFBEventOption.Checked = r_EventSettingsFilter.IsFBEventsDisplayed;
            chckBxFriendLstOption.Checked = r_EventSettingsFilter.IsFriendsBirthdayDisplayed;

            
            foreach (var frnd in r_EventSettingsFilter.FriendsLists)
            {
                chckLstBxFriendLst.Items.Add(frnd);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void chckBxFBEventOption_CheckedChanged(object sender, EventArgs e)
        {
            r_EventSettingsFilter.IsFBEventsDisplayed = chckBxFBEventOption.Checked;
        }

        private void chckBxFriendLstOption_CheckedChanged(object sender, EventArgs e)
        {
            r_EventSettingsFilter.IsFriendsBirthdayDisplayed = chckBxFriendLstOption.Checked;
        }
    }
}
