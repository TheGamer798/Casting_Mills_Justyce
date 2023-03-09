using System;

namespace Casting_Mills_Justyce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a whole number");//ask user for whole number
            int userNumber = Convert.ToInt32(Console.ReadLine());//convert string into int
            Console.WriteLine($"the number you entered is {userNumber}");//prints user's whole number
            Console.WriteLine("true or false");// ask user for true or false
            bool userAnswer = Convert.ToBoolean(Console.ReadLine());//convert string into bool
            Console.WriteLine($"you chose {userAnswer}");//prints user's choose



        }
    }
}
