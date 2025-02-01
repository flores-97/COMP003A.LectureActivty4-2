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
            Console.WriteLine("Hello, World!");
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

    }
}
