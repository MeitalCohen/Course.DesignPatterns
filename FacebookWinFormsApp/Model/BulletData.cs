using System.Collections.Generic;

namespace BasicFacebookFeatures.Model
{
    public class BulletData
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Years { get; set; }
        public List<string> Data { get; set; }
        public bool IsEnabled { get; set; }
        public BulletData(string i_Title, string i_SubTitle = null, string i_Years = null, List<string> i_Data = null, bool i_IsEnabled = true)
        {
            Title = i_Title;
            SubTitle = i_SubTitle;
            Data = i_Data;
            Years = i_Years;
            IsEnabled = i_IsEnabled;
        }
    }
}
