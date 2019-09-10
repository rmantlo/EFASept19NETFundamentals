using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void IfElseStatements()
        {
            int age = 18;
            //if statements are true/false evaluations
            if(age == 18)
            {
                Console.WriteLine("You are 18");
            }

            if (age == 21)
            {
                Console.WriteLine("yay, you can drink");
            }

            if (age != 19)
            {
                Console.WriteLine("you're not 'equal to' 19 years old");
            }

            //greater than/less than
            if (age > 17)
            {
                Console.WriteLine("You're an adult");
            }
            else if (age > 6)
            {
                Console.WriteLine("You're a kid");
            }
            else if (age > 0)
            {
                Console.WriteLine("You are way to young, stop that.");
            }
            else
            {
                Console.WriteLine("How do you exist and reasonably use a computer?");
            }

            //and/or statements:
            if (age < 65 && age > 17)
            {
                Console.WriteLine("You are old enough to be an adult and young enough to be carded at a bar");
            }
            else if (age > 64 || age < 18)
            {
                Console.WriteLine("You are either older than 64 or younger than 18");
            }

        }
        [TestMethod]
        public void SwitchCases()
        {
            //switched do not evalutate true/false but the straight value
            string howDoYouFeel = "tired";
            switch (howDoYouFeel)
            {
                case "happy":
                    Console.WriteLine("Congrats, keep feeling that way");
                    break;
                case "sad":
                    Console.WriteLine("Im sorry, you should probably feel happy instead");
                    break;
                case "angry":
                    Console.WriteLine("breath deeply, we only have like 5 hours left.");
                    break;
                case "tired": //written this way means for all these options lead to same result
                case "bored":
                    Console.WriteLine("Sorry my jokes are bad, and dont keep you entertained.");
                    break;
                default:
                    Console.WriteLine("We didnt consider all feeling options. Default message: eat health, absorb mana.");
                    break;
            }
        }
        [TestMethod]
        public void Ternaries()
        {
            //shorthand if else statements
            //(Condition/boolean)? true result: false result
            string computer = "PC";
            bool isGood = (computer == "PC") ? true : false;

            int numOne = 10;
            int numTwo = (numOne == 10) ? 30 : 20;
            Console.WriteLine((numTwo == 20) ? "numOne does not equal 10" : "numOne does equal 10");
        }
    }
}
