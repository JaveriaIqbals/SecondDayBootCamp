using System;


namespace SecondDayBootCamp
{
    // Class : Properties, Methods
    class Calculator
    {
        // non-static method
        public int Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Addition results in : " + result);
            return result;
        }

        // non-static
        public int Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine("Subtraction results in : " + result);
            return result;
        }

    }
    class Tester
    {
        /*public static void Main(string [] args)
        {
            // Create Object of Calcuator
            Calculator myCalc = new Calculator();// create object
                                                 // 
            // Object will call non-static methods only
            // Without object, we call static methods only
            myCalc.Subtract(100, 40);
            myCalc.Add(100, 100);
            myCalc.Add(10, 100);
            myCalc.Add(20, 100);
            myCalc.Add(3400, 100);
        }*/
    }
}
