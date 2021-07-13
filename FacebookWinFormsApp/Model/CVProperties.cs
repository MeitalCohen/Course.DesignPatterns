using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Model
{
    public class CVProperties
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string UrlLink { get; set; }
        public string JobPosition { get; set; }
        public string PersonalDetails { get; set; }
        public List<BulletData> Experience { get; set; }
        public List<BulletData> Education { get; set; }
        public List<string> Skills { get; set; }
        public List<string> Hobbies { get; set; }

        public CVProperties()
        {

        }
    }
}
