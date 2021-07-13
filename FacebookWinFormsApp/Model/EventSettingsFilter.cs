using System.Collections.Generic;

namespace BasicFacebookFeatures.Model
{
    public class EventSettingsFilter
    {
        public bool IsFBEventsDisplayed { get; set; }
        public bool IsFriendsBirthdayDisplayed { get; set; }
        public List<FriendList> FriendsLists { get; set; }

        public EventSettingsFilter()
        {
            FriendsLists = new List<FriendList>();
        }

        public EventSettingsFilter(EventSettingsFilter i_EventSettingsFilter)
        {
            IsFriendsBirthdayDisplayed = i_EventSettingsFilter.IsFriendsBirthdayDisplayed;
            IsFBEventsDisplayed = i_EventSettingsFilter.IsFBEventsDisplayed;
            FriendsLists = i_EventSettingsFilter.FriendsLists != null 
                ? new List<FriendList>(i_EventSettingsFilter.FriendsLists) 
                : new List<FriendList>();
        }
    }

    public enum eFBEventsStatus
    {
        Declined=1,
        NotYetReplied,
        Maybe
    }
}
