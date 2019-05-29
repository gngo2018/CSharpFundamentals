using System;

namespace ArrayFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Please choose an action: \n" +
                    "1. See Array in reverse order\n" +
                    "2. Fizz Buzz\n" +
                    "3. See Current Menu Items\n" +
                    "4. Exit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        program.ArrayReverse();
                        break;
                    case 2:
                        //DeleteItem();
                        break;
                    case 3:
                        //SeeCurrentMenu();
                        //Console.WriteLine("Press any key to continue!");
                        //Console.ReadKey();
                        break;
                    case 4:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Try again please");
                        Console.ReadKey();
                        break;
                }
            }
            Console.WriteLine("Have a great day!");

        }

        private void ArrayReverse()
        {
            //Array reverse order
            ArrayService arr = new ArrayService();
            int[] a = { 0, 1, 2, 3, 1, 22 };

            arr.ReverseArray(a);

            foreach (var i in a)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Press any key to continue!");

            Console.ReadLine();
        }
    }
}
