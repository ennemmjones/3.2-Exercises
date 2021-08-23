using System;

namespace Exercise_37
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitCondition = true;// set initial state of exit condition
            while (exitCondition)
            {

                Console.WriteLine(SumOfArray(5));

                Console.WriteLine("Would you like to continue (y/n)?"); // prompt user to continue or exit

                if (Console.ReadLine().ToLower() != "y") // user input to continue or exit
                {
                    exitCondition = false; // change condition to exit if user input other than y
                    Console.WriteLine("Goodbye!");
                }
            }            
        }

        public static string SumOfArray(int num)
        {
            double[] numArray = new double[num]; // create new array to store values
            double sum = 0;
            int count = 0;
            string stringSum = String.Empty;
            while (count < num)
            {
                Console.Write("Enter a Number: ");
                if (double.TryParse(Console.ReadLine(), out numArray[count]))  // if user inupt is valid add to array
                {
                    sum += numArray[count]; // add array element to sum
                    stringSum += $"{numArray[count]} + ";  // add to string listing all elements
                    count++;
                }

                else
                {
                    Console.WriteLine("That was not a number, try again.");
                }
            }

            return $"{stringSum.Remove(stringSum.Length-3)} = {sum}"; // output the sum as string showing additon of each element    

        }
    }
}
