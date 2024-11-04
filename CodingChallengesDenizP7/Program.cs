using System;

class Challenges
{


    public static void Main(string[] args)
    {
        Console.WriteLine("WElcoime to my challenges programs! \n please pick one of the programs 1 - 9");
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
                Console.WriteLine("slect a age to convert to days);
                var = Console.ReadLine();
                int numberToUse7 = int.Parse(number7);
                Console.WriteLine("I am going to take an age and convert it  " + CalcAge(numberToUse7) + " is your number plus 1");
            }
            else if (choices == 6)
            {

            }
            else if (choices == 7)
            {

            }
            else if (choices == 8)
            {

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

    public static bool IsEqual(int number13, int number14)
    {
        return number13 == number14;1
    }

}      