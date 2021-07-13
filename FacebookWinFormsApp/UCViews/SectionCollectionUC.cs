using BasicFacebookFeatures.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UCViews
{
    public partial class SectionCollectionUC : UserControl
    {
        private const int k_MaxNumberOfLines = 5;
        private readonly RichTextBox[] m_DescriptionLines = new RichTextBox[k_MaxNumberOfLines];
        private readonly bool m_isEnableEdit;
        public List<string> SectionBulletData { get; set; }
        public SectionCollectionUC(string i_Title, string i_SubTitle, string i_Time, List<string> i_Data = null, bool isEnableEdit = true)
        {
            InitializeComponent();
            
            buildDecriptionLines();

            lblSubTitle.Text = i_SubTitle;
            lblTime.Text = i_Time;
            lblTitle.Text = i_Title;
            m_isEnableEdit = isEnableEdit;

            initializeDataLines(i_Data);
        }

        public SectionCollectionUC(BulletData i_BulletData, bool i_IsEnableEdit = true)
        {
            InitializeComponent();

            buildDecriptionLines();

            lblSubTitle.Text = i_BulletData.SubTitle;
            lblTime.Text = i_BulletData.Years;
            lblTitle.Text = i_BulletData.Title;
            m_isEnableEdit = i_IsEnableEdit;

            initializeDataLines(i_BulletData.Data);
        }

        private void initializeDataLines(List<string> i_Data)
        {
            if (i_Data == null || i_Data.Count == 0)
                return;

            int numberOfLines = i_Data.Count <= k_MaxNumberOfLines ? i_Data.Count : k_MaxNumberOfLines;
            for (int i = 0; i < numberOfLines; i++)
            {
                m_DescriptionLines[i].Text = i_Data[i];
            }
        }

        private void buildDecriptionLines()
        {
            const int textBoxHeight = 30;
            const int textBoxesSpace = 35;
            int X = 0, Y = 0;

            for (int i = 0; i < k_MaxNumberOfLines; i++)
            {
                m_DescriptionLines[i] = new RichTextBox()
                {
                    Parent = pnlDescription,
                    Height = textBoxHeight,
                    Width = pnlDescription.Width - 5,
                    Location = new System.Drawing.Point(X, Y),
                    ReadOnly = !m_isEnableEdit
                };

                Y += textBoxesSpace;
            }
        }
    }
}
