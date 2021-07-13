using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.UCViews
{
    public partial class GeneralInfoUC : UserControl
    {
        public GeneralInfoUC(string i_Name, string i_JobDescription = null, string i_Email = null, 
            string i_LinkUrl = null, string i_Phone = null)
        {
            InitializeComponent();
            lblName.Text = i_Name;
            txtBoxEmail.Text = i_Email;
            txtBoxJobDescription.Text = i_JobDescription;
            txtBoxPhone.Text = i_Phone;
            txtBoxUrl.Text = i_LinkUrl;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
