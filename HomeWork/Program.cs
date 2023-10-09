using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {

        public static void Main(string[] args)
        {

            Car car = new Car("Mercedes", "S Class", 45.4f, 4f, 120_000);

            car.Drive(10);
            car.Drive(20);




            Task2 task2 = new Task2();

            task2.GetUserInput(out string? userInput1, out string? userInput2);

            bool check = task2.CheckInteger(userInput1, userInput2, out int value1, out int value2);

            if (check) task2.Sum(value1, value2);
            else Console.WriteLine("One of the number or Both are not valid integer type.");


            Task3 task3 = new ();
            int[] arr = { 1, 2, 3 };

            Console.WriteLine("Before Push:");
            Program.PrintArr(arr);

           
            Console.WriteLine("\nAfter Push:");
            task3.Push(ref arr, 4);
            Program.PrintArr(arr);

        }

        static void PrintArr(int[] arr) {
        
            foreach(int x in arr)
            {
                Console.Write(x + " ");
            }
        }

    }
}
