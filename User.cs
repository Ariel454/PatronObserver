using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserver
{
    public class User
    {
        public string UserName { get; }
        private List<IFollower> followers = new List<IFollower>();
        private List<string> posts = new List<string>();

        public User(string userName)
        {
            UserName = userName;
        }

        public void Follow(IFollower follower)
        {
            followers.Add(follower);
        }

        public void Unfollow(IFollower follower)
        {
            followers.Remove(follower);
        }

        public void Post(string content)
        {
            posts.Add(content);
            NotifyFollowers(content);
        }

        private void NotifyFollowers(string post)
        {
            foreach (var follower in followers)
            {
                follower.Update($"{UserName} posted: {post}");
            }
        }
    }
}
