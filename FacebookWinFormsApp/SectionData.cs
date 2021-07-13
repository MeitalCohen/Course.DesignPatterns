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
    public partial class SectionData : UserControl
    {
        public SectionData(string i_Title, string i_SubTitle)
        {
            InitializeComponent();
        }

        public string Title { get; set; }
    }
}
