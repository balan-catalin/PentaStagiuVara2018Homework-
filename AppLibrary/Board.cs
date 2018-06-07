using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary
{
    public static class Board
    {
        private static List<Post> Posts = new List<Post>();
        private static List<Account> Accounts = new List<Account>();
        private static Boolean isLoged;
        private static Account LogedInUser=null;

        public static void showMenu()
        {
            if (LogedInUser != null)
                Console.Write($"Loged in as: {LogedInUser}\n");
            Console.WriteLine("1. Create an account");
            Console.WriteLine("2. Show users");
            Console.WriteLine("3. LogIn");
            Console.WriteLine("4. LogOut");
            Console.WriteLine("5. Post");
            Console.WriteLine("6. Show all posts");
            Console.WriteLine("7. Exit!");
            Console.Write(">");
        }

        public static void postMesage()
        {
            if (isLoged)
            {
                Console.Write("Your message is: ");
                String Mesage = Console.ReadLine();
                Post post = new Post(Mesage,LogedInUser,DateTime.Now);
                Posts.Add(post);
            }
            else
                Console.Write("You are not loged!");
        }

        public static void showAllPost()
        {
            for(int i = Posts.Count-1; i >= 0; i--)
            {
                Console.Write($"Post {Posts.Count - i}: {Posts[i]}");
            }
        }

        public static Account getLogedInAccount()
        {
            return LogedInUser;
        }

        public static List<Account> getListAccount()
        {
            return Accounts;
        }
    
        public static void showAccountsList()
        {
            int i = 0;
            foreach (Account ac in Accounts)
            {
                i++;
                Console.WriteLine($"User {i}: {ac}\n");
            }
        }

        public static void addAccount(Account account)
        {
            Accounts.Add(account);
        }

        public static void LogIn()
        {
            LogedInUser = null;
            notExist:
            Console.Write("UserName: ");
            String user = Console.ReadLine();
            foreach (Account ac in Accounts)
            {
                if (ac.getUserName() == user)
                {
                    LogedInUser = ac;
                }
            }
            if (LogedInUser == null)
            {
                Console.Write("This account is not exist!");
                goto notExist;
            }
            retryPass:
            Console.Write("Password: ");
            String pass = Console.ReadLine();
            if (LogedInUser.getPassword() != pass)
            {
                Console.Write("Wrong password!");
                goto retryPass;
            }
            isLoged = true;
        }

        public static void LogOut()
        {
            if (isLoged == true)
            {
                isLoged = false;
                LogedInUser = null;
            }
            else
                Console.WriteLine("You can't LogOut because you are not LogIn.");
        }

    }
}
