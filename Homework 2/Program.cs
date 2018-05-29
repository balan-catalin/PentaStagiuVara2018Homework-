using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            Console.WriteLine("Sa asezam putin textul fara prea multe spatii la inceput sau la sfarsit.");
            str=str.TrimStart();
            str=str.TrimEnd();
            Console.WriteLine(str + "\n");

            Console.WriteLine("Sa facem textul uniform:");
            str = str.ToLower();
            Console.WriteLine(str + "\n");

            Console.WriteLine($"Lungimea textului tau este de {str.Length} caractere.\n");

            Console.WriteLine("Ar trebui sa mai adaugi ceva la textul tau... introdu aici ce urmeaza: ");
            str = String.Concat(str, " " + Console.ReadLine());
            Console.WriteLine(str + "\n");

            Console.WriteLine("Sa facem toate literele mari:");
            str = str.ToUpper();
            Console.WriteLine(str + "\n");

            Console.WriteLine("Acum sa inlocuim fiecare E cu 3, A cu 4, I cu 1, O cu 0, S cu 5");
            str = str.Replace('A', '4');
            str = str.Replace('E', '3');
            str = str.Replace('O', '0');
            str = str.Replace('I', '1');
            str = str.Replace('S', '5');
            Console.WriteLine(str + "\n");
        }
    }
}
