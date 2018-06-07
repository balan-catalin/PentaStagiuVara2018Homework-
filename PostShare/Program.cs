using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLibrary;

namespace PostShare
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Balan = new Account("Balan", "Catalin", new DateTime(1997, 6, 2), "catalin97", "foto.bcatalin@gmail.com", "4567");
            Board.addAccount(Balan);
            Account Duma = new Account("Duma", "Vlad", new DateTime(1997, 6, 2), "dumitza", "dumavlad@gmail.com", "1234");
            Board.addAccount(Duma);
            while (true)
            {
                Board.showMenu();
                int choise;
                if(!int.TryParse(Console.ReadLine(), out choise) || (choise>=8 || choise<1))
                {
                    Console.WriteLine("Introduceti una dintre variante");
                }
                Console.WriteLine();
                switch (choise)
                {
                    case 1:
                        Console.WriteLine("Creating Account...");
                        Account account = new Account();
                        Board.addAccount(account);
                        Console.WriteLine("Account Created!");
                        break;
                    case 2:
                        Board.showAccountsList();
                        break;
                    case 3:
                        Board.LogIn();
                        Console.WriteLine("LogIn successfull!");
                        break;
                    case 4:
                        Board.LogOut();
                        break;
                    case 5:
                        Board.postMesage();
                        break;
                    case 6:
                        Board.showAllPost();
                        break;
                }
                if (choise == 7)
                    break;
                Console.WriteLine();
            }
        }
    }
}
