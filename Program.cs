using PatronObserver;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

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
            user3.Follow(follower1);
            user3.Follow(follower2);

        user1.Post("Hello, this is my first post!");
            user2.Post("I just shared an update!");
            user3.Post("Following more people now.");

            user2.Unfollow(follower1);
            user3.Unfollow(follower2);

            user1.Post("Another post, with fewer followers now.");
            user2.Post("My second update, fewer people will see this.");
            user3.Post("Expanding my network!");

        // Los seguidores recibirán notificaciones solo de los usuarios a los que siguen.

        while (true)
        {

            Console.WriteLine("1. User\n 2.User2\n 3.User3");
            Console.Write("Selecciona un usuario para añadir otro post: ");
            int userp;

        
            if (int.TryParse(Console.ReadLine(), out userp))
            {
                switch (userp)
                {
                    case 1:
                        addPost(user1);
                        break;
                    case 2:
                        addPost(user2);
                        break;
                    case 3:
                        addPost(user3);
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debes ingresar un número.");
            }

        }

    }


    public static void addPost(User user) {

        string post1 = "";

        Console.Write("Ingresa un post: ");
        post1 = Console.ReadLine();

        user.Post(post1);

    }
}