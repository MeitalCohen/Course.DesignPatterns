using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class WelcomeScreen : Form
    {
        private string m_AppId;
        public LoginResult LoginResult { get; set; }
        public WelcomeScreen(string i_AppId)
        {
            InitializeComponent();
            m_AppId = i_AppId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LoginResult = FacebookService.Login(
            //        m_AppId,
            //        /// requested permissions:
            //        "email",
            //        "public_profile",
            //        /// add any relevant permissions
            //        "user_age_range",
            //        "user_birthday",
            //        "user_events",
            //        "user_friends",
            //        "user_gender",
            //        "user_hometown",
            //        "user_likes",
            //        "user_link",
            //        "user_location",
            //        "user_photos",
            //        "user_posts",
            //        "user_videos"
            //        );
        }
    }
}
