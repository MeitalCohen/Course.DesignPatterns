using BasicFacebookFeatures.Model;
using BasicFacebookFeatures.UCViews;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class CreateCVForm : Form
    {
        private User m_User;
        private List<BulletData> experience_data;
        private List<BulletData> education_data;

        public CreateCVForm(User i_User)
        {
            m_User = i_User;

            
            InitializeComponent();

            if (i_User == null)
            {
                BuildDummyExperience();
                BuildDummyEducation();
            }
            else
            {
                if(i_User.WorkExperiences != null)
                {
                    experience_data = new List<BulletData>();

                    for (int i = 0; i < i_User.WorkExperiences.Length; i++)
                    {
                        var workExperience = i_User.WorkExperiences[i];
                        string years = workExperience.StartDate.HasValue == false ? "UnKnown" : $"{workExperience.StartDate.Value.Year}-";
                        years += workExperience.EndDate.HasValue == false ? "Present" : workExperience.EndDate.Value.Year.ToString();

                        experience_data.Add(new BulletData(workExperience.Description, workExperience.Employer.Description, years));
                    }
                }

                if(i_User.Educations != null)
                {
                    education_data = new List<BulletData>();

                    for (int i = 0; i < i_User.Educations.Length; i++)
                    {
                        var education = i_User.Educations[i];
                        education_data.Add(new BulletData($"{education.Type} - {education.Degree.Description}", education.School.Description, education.Year.Description));
                    }
                }
            }
        }

        private void BuildDummyExperience()
        {
            experience_data = new List<BulletData>()
            {
                new BulletData("Team Leader", "Orpak", "2019-2021", new List<string>()
                {
                    "Lorem ipsum",
                    "Lorem ipsum, Lorem ipsum lorem ipsum",
                    "Lorem ipsum lorem ipsum lorem ipsum"
                }),

                new BulletData("Software Engineer", "Orpak", "2019-2021", new List<string>()
                {
                    "Lorem ipsum",
                    "Lorem ipsum, Lorem ipsum lorem ipsum",
                    "Lorem ipsum lorem ipsum lorem ipsum"
                })
            };

        }

        private void BuildDummyEducation()
        {
            education_data = new List<BulletData>()
            {
                new BulletData("Batchlor Degree", "Orpak", "2019-2021", new List<string>()
                {
                    "Lorem ipsum",
                    "Lorem ipsum, Lorem ipsum lorem ipsum",
                    "Lorem ipsum lorem ipsum lorem ipsum"
                }),

                new BulletData("High School", "Orpak", "2019-2021", new List<string>()
                {
                    "Lorem ipsum",
                    "Lorem ipsum, Lorem ipsum lorem ipsum",
                    "Lorem ipsum lorem ipsum lorem ipsum"
                })
            };

        }

        private void clearPanelForms()
        {
            if (panel1.Controls.Count != 0)
                panel1.Controls.Clear();
        }

        private void btnGeneralInfo_Click(object sender, EventArgs e)
        {
            clearPanelForms();

            var generalInfoUC = new GeneralInfoUC(m_User.Name, i_Email: m_User.Email)
            {
                Parent = panel1,
                Dock = DockStyle.Fill
            };

            generalInfoUC.Show();
        }

        private void btnSkills_Click(object sender, EventArgs e)
        {
            clearPanelForms();

            var skillsUc = new SkillsUC()
            {
                Parent = panel1,
                Dock = DockStyle.Fill
            };

            skillsUc.Show();
            
        }

        private void btnExperience_Click(object sender, EventArgs e)
        {
            clearPanelForms();

            var workExperienceSectionUc = new SectionDataUC("Work Experience", experience_data)
            {
                Parent = panel1,
                Dock = DockStyle.Fill
            };

            workExperienceSectionUc.Show();
        }

        private void btnEducation_Click(object sender, EventArgs e)
        {
            clearPanelForms();

            var educationSectionUC = new SectionDataUC("Education", education_data)
            {
                Parent = panel1,
                Dock = DockStyle.Fill
            };

            educationSectionUC.Show();
        }

        private void btnExtraData_Click(object sender, EventArgs e)
        {
            clearPanelForms();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //TODO: Open Next Form
        }
    }
}
