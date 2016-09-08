using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Distribution_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How old are you?");

            int UserAge = int.Parse(Console.ReadLine());

            if (UserAge >= 0 && UserAge <= 2)
            {
                Console.WriteLine("Still in Mama's arms");
            }
            else if (UserAge == 3 || UserAge == 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (UserAge >= 5 && UserAge <= 11)
            {
                Console.WriteLine("Elementary School");
            }
            else if (UserAge >= 12 && UserAge <= 14)
            {
                Console.WriteLine("Middle School");
            }
            else if (UserAge >= 15 && UserAge <= 18)
            {
                Console.WriteLine("High School");
            }
            else if (UserAge >= 19 && UserAge <= 22)
            {
                Console.WriteLine("College");
            }
            else if (UserAge >= 23 && UserAge <= 65)
            {
                Console.WriteLine("Working for the Man");
            }

            else if (UserAge >= 66 && UserAge <= 100)
            {
                Console.WriteLine("The Golden Years");
            }
            else if (UserAge < 0 || UserAge > 100)
            {
                Console.WriteLine("This program is for Humans");
            }
        }
    }
}
