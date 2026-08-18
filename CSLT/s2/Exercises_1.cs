using System;

namespace CSLT.s2
{
    internal class Exercise_1
    {
        public static void Main(string[] args)
        {
            int number1 = 10, number2 = 12;

            //1.to Add / Sum Two Numbers.
            int sum = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {sum}");

            //2.to Swap Values of Two Variables.
            int temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine($"After swapping: ");

            //3.to Multiply two Floating Point Numbers
            float f1 = 3.5f, f2 = 2.7f;
            float f3 = f1 * f2;
            Console.WriteLine($"{f1} * {f2} = {f3}");

            //4.to convert feet to meter
            float feet = 7.5f;
            const float rate = 0.3048f;
            float meter = feet * rate;
            Console.WriteLine($"{feet} feet = {meter} meter");

            //5.to convert Celsius to Fahrenheit and vice versa
            float celsius = 25f;
            float fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C = {fahrenheit}°F");

            //6.to find the Size of data types
            Console.WriteLine($"Size of double data type is {sizeof(double)}");
            Console.WriteLine($"Size of int data is {sizeof(int)}");

            //7.to Print ASCII Value(tip: read character, print number of this char)
            Console.Write("Enter a character: ");
            int c = Console.Read();
            Console.WriteLine($"ASCII code of {(char)c} is {c}");

            //8.to Calculate Area of Circle
            Console.Write("Enter r: ");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine($"Area of circle with radius {r} is: {area}");

            //9.to Calculate Area of Square
            Console.Write("Enter side length: ");
            float side = float.Parse(Console.ReadLine());
            float areaSquare = side * side;
            Console.WriteLine($"Area of square with side length {side} is: {areaSquare}");

            //10.to convert days to years, weeks and days
            Console.Write("Enter number of days: ");
            int days = int.Parse(Console.ReadLine());
            int years = days / 365;
            int weeks = (days % 365) / 7;
            int remainingDays = (days % 365) % 7;
            Console.WriteLine($"{days} days = {years} years, {weeks} weeks, and {remainingDays} days");


            Console.ReadKey();

        }
    }
}

