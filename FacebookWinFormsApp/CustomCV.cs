using BasicFacebookFeatures.Model;
using BasicFacebookFeatures.UCViews;
using FacebookWrapper.ObjectModel;
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
    public partial class CVPreview : Form
    {
        private readonly CVProperties r_CVProperties;

        public CVPreview(CVProperties i_CVProperties)
        {
            r_CVProperties = i_CVProperties;

            InitializeComponent();

            initializeGeneralInfo();
            initializePanel2();
        }

        private void initializeGeneralInfo()
        {
            lblEmail.Text = r_CVProperties.Email;
            lblName.Text = r_CVProperties.Name;
            lblJobDescription.Text = r_CVProperties.JobPosition;
            lblPhoneNumber.Text = r_CVProperties.Phone;
            lblUrl.Text = r_CVProperties.UrlLink;
        }

        int X = 0;
        int Y = 0;

        private void initializePanel2()
        {
            //Build Personl Info Section
            if(string.IsNullOrEmpty(r_CVProperties.PersonalDetails) == false)
            {
                var personalInfoPanel = new Panel()
                {
                    Parent = splitContainer1.Panel2,
                    Location = new Point(X, Y),
                    AutoSize = true,
                    AutoScroll = true
                };

                personalInfoPanel.Controls.Add(new Label()
                {
                    Parent = personalInfoPanel,
                    Location = new Point(X, Y),
                    Text = r_CVProperties.PersonalDetails,
                    Dock = DockStyle.Fill
                });

                Y += personalInfoPanel.Height;
            }

            //Build Experience

            var experiencePanel = new Panel()
            { 
                Parent = splitContainer1.Panel2, 
                Location = new Point(X, Y),
                AutoSize = true,
                AutoScroll = true
            };

            for (int i = 0; i < r_CVProperties.Experience.Count; i++)
            {
                var jobExperiece = r_CVProperties.Experience[i];
                experiencePanel.Controls.Add(new SectionCollectionUC(jobExperiece, false)
                {
                    Parent = experiencePanel,
                    Location = new Point(X, Y),
                    AutoScroll = true
                });

                Y += experiencePanel.Height;
                
            }
            
            //Build Education



            //Build Hobbies

            //Build Skills




        }

        private void initializeExperiece()
        {

        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            //TODO: Export to text file
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }


}
