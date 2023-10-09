using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Task2
    {
       
        public void GetUserInput(out string? inputValue1, out string inputValue2)
        {
            Console.WriteLine("2 Eded daxil edin: ");
            inputValue1 = Console.ReadLine();
            inputValue2 = Console.ReadLine();
        }

        public bool CheckInteger(string? inputValue1, string? inputValue2, out int value1, out int value2)
        {

            bool a = int.TryParse(inputValue1, out value1);
            bool b = int.TryParse(inputValue2, out value2);


            return a && b;

        }

        public void Sum(int a, int b)
        {
            Console.WriteLine($"Sum: {a+b}");
        }
    }

}
