using System;
using System.Runtime.Intrinsics.X86;
class Challenges
{


    public static void Main(string[] args)
    {
        //Welcome the user to my program
        Console.WriteLine("Welcome to my coding challenge program. I will be making a varity of functions for you to use. \n Please pick one");

        Console.WriteLine("We are going to use the number adder today called sum. Please give me two numbers.");

        var number1 = Console.ReadLine();
        int numberToUse1 = int.Parse(number1);

        Console.WriteLine("Got it, give me your 2nd number");
        var number2 = Console.ReadLine();
        int numberToUse2 = int.Parse(number2);

        Console.WriteLine("slect a number to convert from minutes to seconds");
        var number3 = Console.ReadLine();
        int numberToUse3 = int.Parse(number3);

        Console.WriteLine("The sum of the number: " + number1 + " and the number: " + number2 + " is equal to: " + Sum(numberToUse1, numberToUse2));
        Sum(numberToUse1, numberToUse2);

        Console.WriteLine("I am going to convert minutes to seconds. I get " + (numberToUse3) +" seconds per minute");

#pragma warning disable CS8321 // Local function is declared but never used
        static fun getVoltage(context: Context): Int {
            val intent = context.registerReceiver(null, IntentFilter(Intent.ACTION_BATTERY_CHANGED))
    return intent?.getIntExtra(android.os.BatteryManager.EXTRA_VOLTAGE, -1) ?: -1

                git symbolic-ref HEAD | sed - e "s/^refs\/heads\///"



When it's power of 2. Take in mind, that you can use simple and fast shift expression 1 << exponent

example:

            22 = 1 << 2 = (int)Math.pow(2, 2)
210 = 1 << 10 = (int)Math.pow(2, 10)

For larger exponents(over 31) use long instead

232 = 1L << 32 = (long)Math.pow(2, 32)

btw. in Kotlin you have shl instead of << so

(java) 1L << 32 = 1L shl 32(kotlin
    }
#pragma warning restore CS8321 // Local function is declared but never used


        public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }
}

internal class fun
{
}
internal class context
{
}