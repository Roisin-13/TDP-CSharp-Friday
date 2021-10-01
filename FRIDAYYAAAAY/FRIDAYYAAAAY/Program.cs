using System;
using System.Collections.Generic;
namespace FRIDAYYAAAAY
{
    class Program
    {
        static void Main(string[] args)
        {
            //==============LIST======================//
            List<User> users = new List<User>();

            User user1 = new User("Leonardo", "Turtle", "Leo", 7, "Leo@gmail.com");

            User user2 = new User("Raphael", "Turtle", "Raph", 7, "Raph@gmail.com");

            User user3 = new User("Donatello", "Turtle", "Don", 9, "Don@gmail.com");

            User user4 = new User("Michaelangelo", "Turtle", "Mike", 9, "Mike@gmail.com");

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);

            Console.WriteLine("List test with foreach loop");

            foreach (var User in users)
            {
                User.PrintInfo();
            }

            Console.WriteLine();

            //==============QUEUE======================//
            Console.WriteLine("Queue test with foreach loop");

            Queue<User> userque = new Queue<User>();

            userque.Enqueue(user1);
            userque.Enqueue(user2);
            userque.Enqueue(user3);
            userque.Enqueue(user4);

            for (int i = 0; i < userque.Count; i++)
            {
                User userAtFrontOfQueue = userque.Dequeue();
                if (userAtFrontOfQueue != null) i--;
                Console.WriteLine(userAtFrontOfQueue.GetInfo());
            }



        }
    }
}
