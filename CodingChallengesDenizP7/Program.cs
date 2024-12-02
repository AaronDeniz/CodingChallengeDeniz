using System;
using System.ComponentModel.Design;
using System.Linq.Expressions;

class Challenges
{


    public static void Main(string[] args)
    {
        Console.WriteLine("WElcoime to my challenges programs! \n please pick one of the programs 1 - 16");
        var choice = Console.ReadLine();
        int choices = int.Parse(choice);
        bool work = true;
        while (work)
        {
            if (choices == 1)
            {
                Console.WriteLine("Welcome to my coding challenge program. I will be making a varity of functions for you to use. \n Please pick one");

                Console.WriteLine("We are going to use the number adder today called sum. Please give me two numbers.");

                var number1 = Console.ReadLine();
                int numberToUse1 = int.Parse(number1);

                Console.WriteLine("Got it, give me your 2nd number");
                var number2 = Console.ReadLine();
                int numberToUse2 = int.Parse(number2);
                Console.WriteLine("The sum of the number: " + number1 + " and the number: " + number2 + " is equal to: " + Sum(numberToUse1, numberToUse2));
                Sum(numberToUse1, numberToUse2);
            }
            else if (choices == 2)
            {
                Console.WriteLine("slect a number to convert from minutes to seconds");
                var number3 = Console.ReadLine();
                int numberToUse3 = int.Parse(number3);
                Console.WriteLine("I am going to convert minutes to seconds. I get " + Convert(numberToUse3) + " seconds per minute");
            }
            else if (choices == 3)
            {
                Console.WriteLine("slect a number to increment 1");
                var number4 = Console.ReadLine();
                int numberToUse4 = int.Parse(number4);
                Console.WriteLine("I am going to take the number you give and add 1 " + PlusOne(numberToUse4) + " is your number plus 1");
            }
            else if (choices == 4)
            {
                Console.WriteLine("Welcome to my coding challeng 4, today i will take a voltage and a current and return the calculated power \n Please pick one");

                Console.WriteLine("please give me a voltage");

                var number5 = Console.ReadLine();
                int numberToUse5 = int.Parse(number5);

                Console.WriteLine("Got it, give me a current");
                var number6 = Console.ReadLine();
                int numberToUse6 = int.Parse(number6);
                Console.WriteLine("The Circuit Power of the number: " + number5 + " times: " + number6 + " is equal to: " + CircuitPower(numberToUse5, numberToUse6));
                CircuitPower(numberToUse5, numberToUse6);
            }
            else if (choices == 5)
            {
                Console.WriteLine("slect a age to convert to days");
                var number7 = Console.ReadLine();
                int numberToUse7 = int.Parse(number7);
                Console.WriteLine("I am going to take an age and convert it to days" + CalcAge(numberToUse7) + "is your age in days");
            }
            else if (choices == 6)
            {

                Console.WriteLine("please give me the base of the triangle");

                var number7 = Console.ReadLine();
                int numberToUse7 = int.Parse(number7);

                Console.WriteLine("Got it, give me the triangles height");
                var number8 = Console.ReadLine();
                int numberToUse8 = int.Parse(number8);
                Console.WriteLine("The Area of the triangle is: " + number7 + " times: " + number8 + " divided by 2 which equals: " + triArea(numberToUse7, numberToUse8));
                CircuitPower(numberToUse8, numberToUse8);
            }
            else if (choices == 7)
            {
                Console.WriteLine("slect a number and i will tell you if its less than or equal to 0");
                var number10 = Console.ReadLine();
                int numberToUse10 = int.Parse(number10);
                Console.WriteLine("I am goint to tell you if your number is less than or equal to zero" + lessThanOrequalToZero(numberToUse10) );
            }
            else if (choices == 8)
            {
                Console.WriteLine("please give me your first number and i will tell yopu if it is less than 100");

                var number11 = Console.ReadLine();
                int numberToUse11 = int.Parse(number11);

                Console.WriteLine("Got it, give me the triangles height");
                var number12 = Console.ReadLine();
                int numberToUse12 = int.Parse(number12);
                Console.WriteLine("The sum of: " + number11 + " plus: " + number12 + " is: " + lessThan100(numberToUse11, numberToUse12));
            }
            else if (choices == 9)
            {
                Console.WriteLine("welcome to my challenge nine program \n please give me the first number");
                var number13 = Console.ReadLine();
                int numberToUse13 = int.Parse(number13);

                Console.WriteLine("please give me the second number ");
                var number14 = Console.ReadLine();
                int numberToUse14 = int.Parse(number14);
                Console.WriteLine("So the 2 integers now equal to " + IsEqual(numberToUse13, numberToUse14));
            }
            else if (choices == 10)
            {
                Console.WriteLine("type a word to add something to is");
                string words = Console.ReadLine(); 
                Console.WriteLine("your word plus something is" + GiveMeSomething(words));
            }
            else if (choices == 11)
            {
               
            }
            else if (choices == 12)
            {
                Console.WriteLine("give me a number of hours and i will convert it to seconds");
                var number15 = Console.ReadLine();
                int numberToUse15 = int.Parse(number15);
                Console.WriteLine(number15 + "converted from seconds to hours is" + howManySeconds(numberToUse15));
            }
            else if (choices == 13)
            {
                Console.WriteLine("give me a number of sides for a polygon and i will tell you the sum of its internal angles");
                var number16 = Console.ReadLine();
                int numberToUse16 = int.Parse(number16);
                Console.WriteLine(number16 + "sided polgons internal angles is" + SumPolygon(numberToUse16));
            }
            else if (choices == 14)
            {
                Console.WriteLine("type a word and i will add Edabit");
                string words2 = Console.ReadLine();
                Console.WriteLine("your word plus Edabit is" + nameString(words2));
            }
            else if (choices == 15)
            {

            }
            else if (choices == 16)
            {
                Console.WriteLine("please give the amount of 2- pointers during the game");

                var number17 = Console.ReadLine();
                int numberToUse17 = int.Parse(number17);

                Console.WriteLine("Got it, give me the amount of 3-pointers during the game");
                var number18 = Console.ReadLine();
                int numberToUse18 = int.Parse(number18);
                Console.WriteLine("The amount of 2-pointers scored were: " + number17 + " and the amount of 3-pointers scored was: " + number18 + " so the final amount of points scored was: " + points(numberToUse17, numberToUse18));
                CircuitPower(numberToUse18, numberToUse18);
            }
        }
        //Welcome the user to my program
    }
    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }
    public static int Convert(int number3)
    {
        return number3 * 60;
    }
    public static int PlusOne(int number4)
    {
        return number4 + 1;
    }

    public static int CircuitPower(int number5, int number6)
    {
        return number5 * number6;
    }

    public static int CalcAge(int number7)
    {
        return number7 * 365;
    }
    public static int triArea(int number8, int number9)
    {
        return (number8 * number9) / 2;
    }

    public static bool lessThanOrequalToZero(int number10)
    {
        return number10 <= 0;
    }

    public static bool lessThan100(int number11, int number12)
    {
        return number11 + number11 < 100;
    }


    public static bool IsEqual(int number13, int number14)
    {
        return number13 == number14;
    }

    public static string GiveMeSomething(string Words)
    {
        return "something" + Words; 
    }

   

    public static int howManySeconds(int number15)
    {
        return number15 * 3600;
    }

    public static int SumPolygon(int number16)
    {
        return (number16 - 2) * 180;
    }

    public static string nameString(string Words2)
    {
        return Words2 + "Edabit";
    }

    public static int points(int number17, int number18)
    {
        return (number17 * 2) +  number18 * 3;
    }

   
}      