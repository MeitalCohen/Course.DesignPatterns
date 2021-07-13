using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Model
{
    public class ResumeSection
    {
        public string Title { get; set; }
        public eSectionType SectionType { get; set; }

        public eDataType DataType{ get; set; }
        public ResumeSection(eSectionType i_SectionType, string i_Title)
        {
            Title = i_Title;
            SectionType = i_SectionType;
        }
    }

    public enum eDataType
    {
        TextOnly=1,
        Labels,
        TextAsBullet
    };

    public enum eSectionType
    {
        AboutMe=1,
        Experience,
        Education,
        Skills,
        Hobbies,
        PersonalInfo
    };
}
