using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidConsoleApp
{
    internal class UserIO
    {
        static bool isValid = false;
        static string? str_number = null;

        public static double Start() {
            double inputNumber = 0;
            do
            {
                Console.WriteLine("Please chose number between 1 up to 1,000,000,000 ====  or enter e for exit ");
                str_number = Console.ReadLine();
                if (str_number == null)
                {
                    Console.WriteLine("Invalid input");
                }

                if (str_number != null && str_number.ToLower() == "e") break;

                

                isValid = double.TryParse(str_number, out inputNumber);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input -- only numbers allowed");
                    continue;
                }


                if (inputNumber <= 0 )
                {
                    Console.WriteLine("Invalid input -- less then Zero not allowed");
                    isValid = false;
                }


                if (inputNumber > 1_000_000_000 )
                {
                    Console.WriteLine("Invalid input -- Biger than 1,000,000,000 not allowed");
                    isValid = false;
                }

            } while (!isValid);

            return inputNumber;
        }
    }
}
