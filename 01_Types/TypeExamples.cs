using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //-- Stack (static) vs Heap (dynamic) and Garbage Collection
            //HAVE LAWRENCE: Discuss the role of stack and heap. This includes where different typed variables will go and how references work.

            //declaration and initialization of variables
            float firstVariable;
            firstVariable = 7f;

            //types:
            bool on = true;
            bool off = false;

            char character = '@'; //one character, in single quotes

            //whole numbers:
            byte byteExample = 255; //0-255, uncommon;
            sbyte sByteExmaple = -128; //signed bytes that can neg ( -128 - 127 )
            short shortExample = -32768; //-32768 - 32767
            Int16 anotherShortExample = 12312; //same as short
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808; //this and above are whole numbers only

            //decimal numbers:
            float floatExample = 1.012343f; //needs f at end, single precision floating-point number, round after 7 digits
            double doubleExample = 3.234323423423223432; //not suffix needed but can have d at the end, decimal numbers are a default of type double, single precision floating-point number, rounds after 15 digits
            decimal decimalExample = 1.123456789m; //needs m at end, not meaning for the m, for extreme precision, longest of all decimal types


            //structs - actually a value type, object, can be instantiated without using a new operator.
            //debug to show
            DateTime today = DateTime.Today; //stores both a date and a time, multiple type, ie today/now/tomorrow, days in month etc,
            DateTime someDay = new DateTime(1978, 1, 1); //creates new datetime value, hover over to show argument types
            TimeSpan timeSpanExample = today - someDay; //math, result is the number of days that has passed.
            Console.WriteLine(someDay);
        }
        [TestMethod] //testm tab tab
        public void Operators()
        {
            int numOne = 15;
            int numTwo = 7;
            //run tests
            int sum = numOne + numTwo;
            int diff = numOne - numTwo;
            int quot = numOne / numTwo; //nearest whole number
            int prod = numOne * numTwo;
            int remainder = numOne % numTwo; //remainer from division
        }
        [TestMethod]
        public void ReferenceTypes()
        {
            //reference types are technically classes
            string firstName = "john"; //double quotes
            string age = "42";
            string lastName = "smith";

            //concatenation
            string name = firstName + " " + lastName;

            //Composite formatting
            string compositeFullName = string.Format("{0} {1}", firstName, lastName);

            //String interpolation
            string interpolationName = $"{firstName} {lastName}";
            //right click typeExmaples file and debug, use text explorer to run tests and see outputs
            Console.WriteLine(firstName);
            Console.WriteLine(interpolationName);
            Console.WriteLine(compositeFullName);

            //Collections - i.e. Arrays, Lists, Dictionaries
            string banana = "An awesome fruit";
            string[] strArray = { "Hello", "Ahhhh", "World", "I'm suck in a computer", banana, "?" }; //must all be of type string
            string[] anotherArray = new string[17]; //needs pre determined array length in this format
            //debug to show!
            anotherArray[7] = "8th item";//debug to show!

            List<string> listExample = new List<string>();
            listExample.Add(banana); //these are like javascript arrays
            listExample.Add("hello");
            listExample.Remove(banana); //remove specific item;

            //debug here
            Queue<int> queueExample = new Queue<int>(); //first in, first out collection of objects/arrays
            queueExample.Enqueue(1);
            queueExample.Enqueue(2);
            var returnedItem = queueExample.Dequeue(); //only removes and returns the top item, first index item;
            Console.WriteLine(returnedItem);
            Dictionary<int, string> dictionaryExample = new Dictionary<int, string>(); //Key Value relations
            dictionaryExample.Add(144, "hi");
        }
    }
}
