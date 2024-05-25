using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSocialMedia
{
    internal class SocialMedia
    {
        Dictionary<string, List<string>> media = new Dictionary<string, List<string>>();
        public SocialMedia() 
        {
            media = new Dictionary<string, List<string>>();
        }
        public void AddFriend(string username, List<string> friendName)
        {
            if (!media.ContainsKey(username))
                media[username] = friendName;
            else
                media[username].AddRange(friendName);
        }
        public void RemoveFriend(string username, string friendname)
        {
           
            
                media[username].Remove(friendname);
            
        }
        public void GetAllFriendsByUsername(string username) 
        {
            Console.WriteLine(username + " friends: ");
            foreach (string friend in media[username])
            {
                Console.WriteLine(friend);
            }
        }
    }
}
