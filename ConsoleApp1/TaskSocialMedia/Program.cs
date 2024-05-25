namespace TaskSocialMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SocialMedia media = new SocialMedia();
            media.AddFriend("Cavid", new List<string> { "AAA", "BBB", "CCC", "DDD" });
            media.RemoveFriend("Cavid", "CCC");
            media.GetAllFriendsByUsername("Cavid");
        }
    }
}
