using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary
{
    public class Account
    {
        private Person User;
        private String UserName;
        private String Email;
        private string Password;

        public Account()
        {
            Console.WriteLine("\tPersonal data: ");
            User = new Person();
            Console.WriteLine("\tSingIn data: ");
            Email = readEmail();
            UserName = readUserName();
            Password = readPassword();
        }

        public Account(String FirstName, String LastName, DateTime date, String UserName, String Email, string Password)
        {
            User = new Person(FirstName, LastName, date);
            this.UserName = UserName;
            this.Email = Email;
            this.Password = Password;
        }

        private String readEmail()
        {
            Console.Write("\tEmail: ");
            retryEmail:
            String email = Console.ReadLine();
            foreach (Account ac in Board.getListAccount())
            {
                if (ac.getEmail() == email)
                {
                    Console.WriteLine("\tThis email is allready exist!\nTry another.");
                    goto retryEmail;
                }
            }
            return email;
        }

        private String readPassword()
        {
            Console.Write("\tPassword: ");
            return Console.ReadLine();
        }

        private String readUserName()
        {
            Console.Write("\tUserName: ");
            retryUser:
            String user = Console.ReadLine();
            foreach (Account ac in Board.getListAccount())
            {
                if (ac.getUserName() == user)
                {
                    Console.WriteLine("\tThis user is allready exist!\nTry another.");
                    goto retryUser;
                }
            }
            return user;
        }

        public Person getUser()
        {
            return User;
        }

        public String getUserName()
        {
            return UserName;
        }

        public String getEmail()
        {
            return Email;
        }

        public String getPassword()
        {
            return Password;
        }

        public override string ToString()
        {
            return "Name: " + User.ToString() + " | Email: " + Email + " | Username: " + UserName;
        }
    }
}
