// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/// калькулятор

using System;
namespace ConsoleApp1;

class ProgramCalc
{

    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        string input1 = Console.ReadLine();
        //double num1 = double.Parse(Console.ReadLine());
        if (!double.TryParse(input1, out double num1))
        {
            Console.WriteLine("Ошибка: введенное значение не является числом.");
            return;
        }

        Console.WriteLine("Введите операцию (допустимые операции: + - * /)");
        char action = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (action != '+' && action != '-' && action != '*' && action != '/')
        {
            Console.WriteLine("Ошибка: введена неверная операция. Допустимые операции: + - * /");
            return;
        }

        Console.Write("Введите второе число: ");
        Console.WriteLine();
        string input2 = Console.ReadLine();
        if (!double.TryParse(input2, out double num2))
        {
            Console.WriteLine("Ошибка: введенное значение не является числом.");
            return;
        }

       

        if (action == '+')
        {
            double result = num1 + num2;
            Console.WriteLine($@"Результат = {result}");
        }
        else if (action == '-')
        {
            double result = num1 - num2;
            Console.WriteLine($@"Результат = {result}");
        }
        else if (action == '*')
        {
            double result = num1 * num2;
            Console.WriteLine($@"Результат = {result}");
        }
        else if (action == '/')
        {

            if (num2 == 0)
            {
                Console.WriteLine("Ошибка. Деление на ноль.");
            }
            else
            {
                double result = num1 / num2;
                Console.WriteLine($@"Результат = {result}");
            }

        }
    

    }
}