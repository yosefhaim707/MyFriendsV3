namespace MyFriendsV3.Models
{
    public class CombinedModel
    {
        public IEnumerable<User> Users { get; set; } = new List<User>();
        public Picture Picture { get; set; }
    }
}
