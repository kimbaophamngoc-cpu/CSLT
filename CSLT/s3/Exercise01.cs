using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.s3
{
    internal class Exercise01
    {
        public static void Main(string[] args)
        {
            //1. The Celsius scale is centigrade, 100 divisions separate the freezing point from the boiling point of water.On the Fahrenheit scale of Anglo-Saxons, these two points are 180 degrees apart. The Kelvin scale is an absolute scale used in science. ▸Create a C# program to convert from degrees Celsius to Kelvin and Fahrenheit. 
            Console.Write("Enter temperature in Celsius: ");
            if (double.TryParse(Console.ReadLine(), out double celsius))
            {
                double kelvin = celsius + 273;
                double fahrenheit = (celsius * 18 / 10) + 32;
                Console.WriteLine($"{celsius}°C = {kelvin} K");
                Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
            }
            else
            {
                Console.WriteLine("Invalid input for temperature.");
            }

            //2. Create a program in C# for calculate the surface and volume of a sphere, given its radius.
            Console.Write("Enter radius of the sphere: ");
            if (double.TryParse(Console.ReadLine(), out double radius))
            {
                double surfaceArea = 4 * Math.PI * radius * radius;
                double volume = (4.0 / 3.0) * Math.PI * radius * radius * radius;
                Console.WriteLine($"Surface area of sphere with radius {radius} is: {surfaceArea}");
                Console.WriteLine($"Volume of sphere with radius {radius} is: {volume}");
            }
            else
            {
                Console.WriteLine("Invalid input for radius.");
            }

            //3. Write a program in C# that calculates the result of adding, subtracting, multiplying and dividing two numbers entered by the user. In addition you should also calculate the rest of the division on the last line.
            Console.Write("Enter first number: ");
            if (double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.Write("Enter second number: ");
                if (double.TryParse(Console.ReadLine(), out double num2))
                {
                    double sum = num1 + num2;
                    double difference = num1 - num2;
                    double product = num1 * num2;
                    double quotient = num1 / num2;
                    double remainder = num1 % num2;
                    Console.WriteLine($"{num1} + {num2} = {sum}");
                    Console.WriteLine($"{num1} - {num2} = {difference}");
                    Console.WriteLine($"{num1} * {num2} = {product}");
                    Console.WriteLine($"{num1} / {num2} = {quotient}");
                    Console.WriteLine($"{num1} mod {num2} = {remainder}");
                }
                else
                {
                    Console.WriteLine("Invalid input for second number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for first number.");
            }
        }   
    }
}
