using System;
using System.Reflection;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu() {
            Console.Clear();
            Console.WriteLine("╔═════════════╗");
            Console.WriteLine("  CALCULATOR  ");
            Console.WriteLine("╚═════════════╝");
            Console.WriteLine("┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉");
            Console.WriteLine("Which one of the options do you want to type?");
            Console.WriteLine("[1] - Sum");
            Console.WriteLine("[2] - Subtract");
            Console.WriteLine("[3] - Divide");
            Console.WriteLine("[4] - Multiply");
            Console.WriteLine("[5] - Bhaskara");
            Console.WriteLine("[6] - Exit the program");
            Console.WriteLine("┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉┉");

            Console.WriteLine("Type the option: ");
            short op = short.Parse(Console.ReadLine());

            switch(op) {
                case 1: Sum(); break;
                case 2: Subtract(); break;
                case 3: Divide(); break;
                case 4: Multiply(); break;
                case 5: Bhaskara(); break;
                case 6: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Sum() {
            Console.Clear();

            Console.WriteLine("Type the first value: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the second value: ");
            double v2 = double.Parse(Console.ReadLine());

            var sum = v1 + v2;

            Console.WriteLine("Sum result: " + sum);
            Console.ReadKey();
            Menu();
        }
        static void Subtract() {
            Console.Clear();

            Console.WriteLine("Type the first value: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the second value: ");
            double v2 = double.Parse(Console.ReadLine());

            var sub = v1 - v2;

            Console.WriteLine("Subtract result: " + sub);
            Console.ReadKey();
            Menu();
        }
        static void Divide() {
            Console.Clear();

            Console.WriteLine("Type the first value: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the second value: ");
            double v2 = double.Parse(Console.ReadLine());

            var div = v1 / v2;

            Console.WriteLine("Divide result: " + div);
            Console.ReadKey();
            Menu();
        }
        static void Multiply() {
            Console.Clear();

            Console.WriteLine("Type the first value: ");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the second value: ");
            double v2 = double.Parse(Console.ReadLine());

            var mul = v1 * v2;

            Console.WriteLine("Multiply result: " + mul);
            Console.ReadKey();
            Menu();
        }
        static void Bhaskara() {
            Console.Clear();

            Console.WriteLine("Based on the second degree equation: ax^2 + bx + c = 0");
            Console.WriteLine("Type the value of a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the value of b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the value of c: ");
            double c = double.Parse(Console.ReadLine());

            double delta = Math.Pow(b, 2) - (4 * a * c);

            double x1 = - b + Math.Sqrt(delta) / 2 * a;
            double x2 = - b - Math.Sqrt(delta) / 2 * a;

            Console.WriteLine("Delta result: " + delta);
            Console.WriteLine("X1 result: " + x1);
            Console.WriteLine("X2 result: " + x2);
            Console.ReadKey();
            Menu();
        }
    }
}