// Author: Victor Flores
// Course: COMP003A
// Faculty: Jonathan Cruz
// Purpose: Practice implementing methods in C#
namespace COMP003A.LectureActivty4_2
{
    internal class Program
    {
       static void Main(string[] args)
        {
            GreetUser();//greets user

            //input two nums and calculate
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());//reads number enters as num1

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());//reads second num as  num2

            int sum = CalculateSum(num1, num2);//call the method and store the results
            Console.WriteLine($"The sum of {num1} + {num2} is {sum}.");

            //display contents of an array
            int[] numbers = { 10, 20, 30, 40, 50 };//initiate array
            Console.WriteLine("Array contents: ");
            DisplayArray(numbers);//call method to print array
        }
        /// <summary>
        /// 
        /// </summary>
        static void GreetUser()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();//reads name
            Console.WriteLine($"Hello, {name}! Welcome to the Methods Activity.");//greets with name 
        }

        ///<summary>
        ///calculate sum of two numbers and return result
        ///</summary>
        ///<param name="num1">Integer of Number 1</param>
        ///<param name="num1">Integer of Number 1</param>
        ///<return>Integer sum of two integer inputs</return>
        ///
        static int CalculateSum(int num1, int num2)
        {
            return num1 + num2;//adds both nums
        }

        ///<summary>
        ///Display contents of an array
        ///</summary>
        ///<param name="numbers">Array collection of integers</param>
        
        static void DisplayArray(int[] numbers)
        {
            foreach (int num in numbers)//loops array
            {
                Console.WriteLine(num);//prints each number
            }
        }
    }
}
