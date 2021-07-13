namespace BasicFacebookFeatures.Model
{
    public class FriendList
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public FriendList(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
