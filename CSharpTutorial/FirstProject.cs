using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class FirstProject
    {
        static void Main()
        {

            FirstProject.EvenNumbers(10);
            FirstProject P = new FirstProject();
           int Sum =  P.Add(10, 20);
            Console.WriteLine("Sum equals {0}", Sum);


            //.....SWITCH STATEMENT.....

            /*
            int TotalCoffeeCost = 0;

        Start:
            Console.WriteLine("Welcome!!! \nWhat do you want to buy?");

            Console.WriteLine("1-Small, 2-Midi, 3-Big");
            int UserChoice = int.Parse(Console.ReadLine());

            switch (UserChoice)
            {
                case 1:
                    //Console.WriteLine("This is small");
                    TotalCoffeeCost += 1;
                break;

                case 2:
                    //Console.WriteLine("This is Midi");
                    TotalCoffeeCost += 2;
                break;

                case 3:
                   // Console.WriteLine("This is Big");
                    TotalCoffeeCost += 3;
                break;

                default:
                    Console.WriteLine("Your choice {0} is invalid", UserChoice);
                    goto Start;
            }

            Decide:
            Console.WriteLine("Do you still want to buy any other item? Yes, No");
            string userDecision = Console.ReadLine();

            switch (userDecision.ToUpper())
            {
                case "YES":
                    goto Start;

                case "NO":
                    break;

                default:
                    Console.WriteLine("Your decision {0} is invalid, Please try again...", userDecision);
                    goto Decide;
            }
            Console.WriteLine("Bill Amount = {0}", TotalCoffeeCost);
            Console.WriteLine("Thank you for your patronage!!!");
            */





            //.....SIMPLE PROGRAM IN C#.....

            /*
             int[] evenNum = new int[] { 1, 2, 3, 4, 5 };
             Console.WriteLine(evenNum);
             Console.WriteLine("What's your name");
             var name = Console.ReadLine();
             Console.WriteLine($"My name is {name}");
             */
            //Console.WriteLine("My name is {0}", name);
        }

        public int Add(int FirstNum, int SecondNum)
        {
            return FirstNum + SecondNum;
        }

        public static void EvenNumbers(int Number)
        {
            //.....WHILE LOOP.....
            //Console.WriteLine("Please enter your Target Number");
            //int Number = int.Parse(Console.ReadLine());

            int i = 0;
            while (i <= Number)
            {
                Console.Write(i);
                i = i + 2;
                Console.ReadLine();

            }
        }

    }
}
