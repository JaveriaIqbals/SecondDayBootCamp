using System;


namespace SecondDayBootCamp
{
    internal class Program
    { 
        // static 
        static void Print()
        {
            Console.WriteLine("Second day Bootcamp");
            
        }

        static void Add(int num1, int num2)
        {
            long result = num1 + num2;
            Console.WriteLine("Addition of number : " + result); 
        }
        /*static void Main(string[] args)
        {
            Print();    // Method call
            Add(20, 30);
            Add(345, 4567);
            Add(1000, 45678);
        }*/
    }
}
