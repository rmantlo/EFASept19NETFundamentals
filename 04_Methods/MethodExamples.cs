using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class MethodExamples
    {
        [TestMethod]
        public void Methods()
        {
            //This is where they will do their calculator challenge! write a method for each operation, and call it;
            //walk them through add method, remind about how ints are whole numbers.
            //15 minutes
            //after walk through the rest with them
            //go over divide by zero issue
            int numOne = 5;
            int numTwo = 3;
            AddTwoNumbers(numOne, numTwo);
            AddTwoNumbers(1, 3);

            int x = 4, y = 4; //nice short for multiple sames
            int numberOne = int.Parse("17");
            string response = "5";
            int numberTwo = int.Parse(response);
            int sumTwo = AddTwoNumbers(numberOne, numberTwo);
            Console.WriteLine(sumTwo);

            //they do this
            int subtract = SubTwoNumbers(5, 3);
            int multiply = MultTwoNumbers(4, 4);
            int divide = Convert.ToInt32(DivideTwoNumbers(8, 2));
            float dividend = DivideTwoNumbers(4, 0); //to avoid issues with divide by errors, gives infinity
            int remainder = RemainderOfTwoNumbers(34, 9);
        }
        //Access modifier (public, private, internal) Default is internal
        //The internal keyword is an access modifier for types and type members. We can declare a class as internal or its member as internal. Internal members are accessible only within files in the same assembly (.dll). In other words, access is limited exclusively to classes defined within the current project assembly
        //Return type (the type that the method returns or spits out)
        //Method signature (method name, and the parameters)
        private int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }


        private int SubTwoNumbers(int a, int b)
        {
            return a - b;
        }
        private int MultTwoNumbers(int a, int b)
        {
            return a * b;
        }
        private float DivideTwoNumbers(float a, float b)
        {
            //return a/b; will create run time error is divided by 0, fix out of method
            return a / b;
        }
        private int RemainderOfTwoNumbers(int a, int b)
        {
            return a % b;
        }
    }
}
