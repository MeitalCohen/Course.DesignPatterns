using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using BasicFacebookFeatures.Model;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const string k_AppId = "254567499335884";
        private WelcomeScreen m_WelcomeScreen;
        
        public FormMain()
        {
            eventFilter = builder();
            //    m_WelcomeScreen = new WelcomeScreen(k_AppId);
            //    if(m_WelcomeScreen.DialogResult == DialogResult.OK)
            //    {
            //        m_LoginResult = m_WelcomeScreen.LoginResult;
            //    }
            //    else
            //    {
            //        Environment.Exit();
            //    }

            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;

        }

        User m_LoggedInUser;
        LoginResult m_LoginResult;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            m_LoginResult = FacebookService.Login(
                    /// (This is Desig Patter's App ID. replace it with your own)
                    k_AppId, 
                    /// requested permissions:
					"email",
                    "public_profile",
                    /// add any relevant permissions
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "groups_access_member_info",
                    "publish_to_groups",
                    "publish_video",
                    "user_videos"
                    );

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";

                m_LoggedInUser = m_LoginResult.LoggedInUser;
                InitializePageData();
                //fetchUserInfo();
            }
            else
            {
                var errorMessage = string.IsNullOrEmpty(m_LoginResult.ErrorMessage) 
                    ? "Failed to login" : m_LoginResult.ErrorMessage;
                MessageBox.Show(errorMessage, "Login Failed");
            }
        }

        private void InitializePageData()
        {
            picBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            lblUserName.Text = m_LoggedInUser.Name;
            lblStatus.Text = m_LoggedInUser.RelationshipStatus.HasValue ? m_LoggedInUser.RelationshipStatus.Value.ToString() : "Unknown";

            
            
        }

        private List<Model.FriendList> GetFreindsList()
        {
            friendsListsOptions = new List<Model.FriendList>();
            if (m_LoggedInUser.Friends.Any())
            {
                foreach (var friend in m_LoggedInUser.Friends)
                {
                    friendsListsOptions.Add(new Model.FriendList(friend.Id, friend.Name));
                }
            }
            return friendsListsOptions;
            //if(m_LoggedInUser.FriendLists.Any())
            //{
            //    foreach (var friendLst in m_LoggedInUser.FriendLists)
            //    {
            //        friendsListsOptions.Add(new Model.FriendList(friendLst.Id, Name));
            //    }
            //}

        }

        private List<Model.FriendList> friendsListsOptions;
        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
		}

        private void btnJob_Click(object sender, EventArgs e)
        {
        }

        private void btnFilterEvents_Click(object sender, EventArgs e)
        {
            if (m_LoggedInUser == null)
            {
                MessageBox.Show("Must login");
                return;
            }
            eventFilter.FriendsLists = GetFreindsList();
            eventsSettings  = new EventSettingsForm(eventFilter.IsFBEventsDisplayed, eventFilter.IsFriendsBirthdayDisplayed, eventFilter.FriendsLists);
            eventsSettings.ShowDialog();
            if(eventsSettings.DialogResult == DialogResult.OK || eventsSettings.DialogResult == DialogResult.Yes)
            {
                eventFilter = new EventSettingsFilter(eventsSettings.EventSettingsFilter);
            }
        }
        private EventSettingsForm eventsSettings;
        private EventSettingsFilter eventFilter;
        private EventSettingsFilter builder()
        {
            return new EventSettingsFilter()
            {
                FriendsLists = new List<Model.FriendList>(),
                IsFBEventsDisplayed = true,
                IsFriendsBirthdayDisplayed = true
            };
        }

        private void btnClearEvent_Click(object sender, EventArgs e)
        {
            listBoxEvents.Items.Clear();
            eventFilter = builder();
            calenderEvent.RemoveAllBoldedDates();
            calenderEvent.SetSelectionRange(DateTime.Today,DateTime.Today);
        }
    }
}
