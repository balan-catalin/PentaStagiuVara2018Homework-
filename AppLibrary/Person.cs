using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary
{
    public class Person
    {
        private String firstName;
        private String lastName;
        private DateTime birthDate;

        public Person()
        {
            firstName = readFirstName();
            lastName = readLastName();
            birthDate = readBirtDate();
        }

        public Person(String firstName, String lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }
        
        private String readFirstName()
        {
            Console.Write("\tFirst Name: ");
            return Console.ReadLine();
        }

        private String readLastName()
        {
            Console.Write("\tLast Name: ");
            return Console.ReadLine();
        }
        
        private DateTime readBirtDate()
        {
            Console.WriteLine("\tBirth Date: ");
            retryYear:
            Console.Write("\tyear - ");
            int year;
            if (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("\tInsert a valid year!");
                goto retryYear;
            }

            retryMounth:
            Console.Write("\tmounth - ");
            int mounth;
            if (!int.TryParse(Console.ReadLine(), out mounth) || (mounth<=0 || mounth>12))
            {
                Console.WriteLine("\tInsert a valid mounth!");
                goto retryMounth;
            }

            retryDay:
            Console.Write("\tday - ");
            int day=1;
            switch (mounth)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (!int.TryParse(Console.ReadLine(), out day) || (day<=0 || day>31))
                    {
                        Console.WriteLine("\tInsert a valid day!");
                        goto retryDay;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (!int.TryParse(Console.ReadLine(), out day) || (day <= 0 || day > 30))
                    {
                        Console.WriteLine("\tInsert a valid day!");
                        goto retryDay;
                    }
                    break;
                case 2:
                    if (!int.TryParse(Console.ReadLine(), out day) || (day <= 0 || day > 28))
                    {
                        Console.WriteLine("\tInsert a valid day!");
                        goto retryDay;
                    }
                    break;
            }
            return new DateTime(year,mounth,day);
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
