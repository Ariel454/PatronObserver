using PatronObserver;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        User user1 = new User("User1");
        User user2 = new User("User2");
        User user3 = new User("User3");

        Follower follower1 = new Follower("Follower1");
        Follower follower2 = new Follower("Follower2");
        Follower follower3 = new Follower("Follower3");

        user1.Follow(follower1);
        user2.Follow(follower1);
        user2.Follow(follower2);
        user3.Follow(follower2);
        user3.Follow(follower3);

        user1.Post("Hello, this is my first post!");
        user2.Post("I just shared an update!");
        user3.Post("Following more people now.");

        user2.Unfollow(follower1);
        user3.Unfollow(follower2);

        user1.Post("Another post, with fewer followers now.");
        user2.Post("My second update, fewer people will see this.");
        user3.Post("Expanding my network!");

        // Los seguidores recibirán notificaciones solo de los usuarios a los que siguen.
    }
}