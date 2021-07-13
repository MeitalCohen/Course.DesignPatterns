using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UCViews
{
    public partial class SkillsUC : UserControl
    {
        private string m_lastSkill;
        int X = 0, Y = 0;

        public SkillsUC()
        {
            InitializeComponent();
        }

        private void btnAddSkill_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtBoxSkill.Text))
            {
                MessageBox.Show("Skill cannot be empty", "Error");
            }
            else
            {
                if (isSkillUnique(txtBoxSkill.Text))
                {
                    BuildSkillsSection(txtBoxSkill.Text);
                    m_lastSkill = txtBoxSkill.Text;
                    txtBoxSkill.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Skill already exists", "Error");
                }
            }
        }

        private bool isSkillUnique(string skill)
        {
            bool isUnique = true;
            if (string.IsNullOrEmpty(skill) == false && pnlSkills.Controls.Count != 0)
            {
                foreach (var control in pnlSkills.Controls)
                {
                    if (control is Label lbl && lbl.Text == skill)
                    {
                        isUnique = false;
                        break;
                    }
                }

            }
            return isUnique;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            if (pnlSkills.Controls.Count != 0)
            {
                var dialogResult = MessageBox.Show("Are you sure you want to clear all skills?", "Clear all", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    pnlSkills.Controls.Clear();
                    m_lastSkill = null;
                    X = 0;
                    Y = 0;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(m_lastSkill) == false && pnlSkills.Controls.Count != 0)
            {
                Label labelToDelete = null;
                foreach (var control in pnlSkills.Controls)
                {
                    if(control is Label lbl && lbl.Text == m_lastSkill)
                    {
                        labelToDelete = lbl;
                        break;
                    }
                }

                if (labelToDelete != null)
                {
                    X -= (labelToDelete.Width + 20);
                    pnlSkills.Controls.Remove(labelToDelete);
                    m_lastSkill = null;
                }
                else
                {
                    MessageBox.Show($"Failed to remove {m_lastSkill} skill", "Error");
                }
            }
        }

        private void BuildSkillsSection(string i_NewSkill)
        {
            int labelsGap = 20;
            int labelsLevelsGap = 10;
            var lblSkill = new Label
            {
                Parent = pnlSkills,
                Text = i_NewSkill,
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
            };

            lblSkill.DoubleClick += LblSkill_DoubleClick;
            if (X + lblSkill.Width >= pnlSkills.Width)
            {
                X = 0;
                Y += lblSkill.Height + labelsLevelsGap;
            }
            lblSkill.Location = new Point(X, Y);
            X += lblSkill.Width + labelsGap;
            pnlSkills.Controls.Add(lblSkill);
        }

        private void LblSkill_DoubleClick(object sender, EventArgs e)
        {
            var lblSkill = (Label)sender;
            txtBoxSkill.Text = lblSkill.Text;
            m_lastSkill = lblSkill.Text;
        }
    }
}
