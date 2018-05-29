using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module01Week02
{
    class Homework1
    {
        public enum Gender
        {
            Male,
            Female
        }

        static void Main(string[] args)
        {
            int year, mounth, day;

            Console.WriteLine("Introduceti anul: ");
            while (!int.TryParse(Console.ReadLine(), out year))
                Console.WriteLine("Nu ati introdus un numar valid.");

            Console.WriteLine("Introduceti luna: ");
            while (!int.TryParse(Console.ReadLine(), out mounth))
                Console.WriteLine("Nu ati introdus un numar valid.");

            Console.WriteLine("Introduceti ziua: ");
            while (!int.TryParse(Console.ReadLine(), out day))
                Console.WriteLine("Nu ati introdus un numar valid.");

            DateTime birthDay = new DateTime(year, mounth, day);

            TimeSpan dif = DateTime.Now.Subtract(birthDay);
            int age = (int)(dif.TotalDays / 365.25);

            Console.WriteLine("Varsta este: " + age);

            Console.WriteLine("Gender is: (M/F)");
            Gender gender = new Gender();

            retry:
            String gnd = Console.ReadLine();
            switch (gnd) {
                case "m":
                case "M": gender = Gender.Male;
                    break;
                case "f":
                case "F":
                    gender = Gender.Female;
                    break;
                default:
                    Console.WriteLine("Va rugam introduceti una dintre obtiuni!");
                    goto retry;
            }
            const int retiredMaleAge = 65;
            const int retiredFemaleAge = 63;

            if ((gender == Gender.Male && age > retiredMaleAge) || (gender == Gender.Female && age > retiredFemaleAge))
            {
                Console.WriteLine("Persoana este la pensie!");
            }
            else if(gender == Gender.Male)
                Console.WriteLine(gender + " at " + retiredMaleAge);
            else
                Console.WriteLine(gender + " at " + retiredFemaleAge);
        }
    }
}
