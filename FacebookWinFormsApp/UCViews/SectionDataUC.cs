using BasicFacebookFeatures.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UCViews
{
    public partial class SectionDataUC : UserControl
    {
        public int DataResult { get; set; }
        public  List<BulletData> Data { get; set; }

        public SectionDataUC(string i_Title, List<BulletData> i_Data)
        {
            Data = i_Data;

            InitializeComponent();
            buildDataTree();

            lblSectionTitle.Text = i_Title;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show($"{lblSectionTitle.Text} Saved!", "Save Changes");
        }

        private void buildDataTree()
        {
            int m_checkBoxX = 20, m_Y = 0;
            int m_checkBoxY = 10;

            foreach (var data in Data)
            {
                var checkBox = new CheckBox
                {
                    Parent = splitContainer1.Panel2,
                    Checked = data.IsEnabled,
                    Text = string.Empty,
                    Tag = data,
                    Location = new System.Drawing.Point(m_checkBoxX, m_checkBoxY)
                };

                checkBox.CheckedChanged += CheckBox_CheckedChanged;

                m_checkBoxX += 15;

                var sectionUC = new SectionCollectionUC(data.Title, data.SubTitle, data.Years, data.Data)
                {
                    Parent = splitContainer1.Panel2,
                    Tag = data,
                    Location = new System.Drawing.Point(m_checkBoxX, m_Y)
                };

                sectionUC.BringToFront();
                m_checkBoxX = 20;
                m_Y += 270;
                m_checkBoxY += m_Y;
            }
        }

        private void CheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            var data = (BulletData)checkBox.Tag;
            data.IsEnabled = checkBox.Checked;
        }
    }
}
