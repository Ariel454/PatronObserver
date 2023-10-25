using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObserver
{
    public class Follower : IFollower
    {
        public string FollowerName { get; }
        public Follower(string followerName) 
        {
            FollowerName = followerName;
        }

        public void Update(string post)
        {
            Console.WriteLine($"{FollowerName} received an update: {post}");
        }

    }
}
