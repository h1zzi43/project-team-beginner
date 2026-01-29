using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Простой калькулятор ===");
            Console.WriteLine("Добро пожаловать!");

            Calculator calculator = new Calculator();

            while (true)
            {
                Console.WriteLine("\nВыберите операцию:");
                Console.WriteLine("1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Умножение");
                Console.WriteLine("4. Деление");
                Console.WriteLine("5. Выход");

                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();

                if (choice == "5") break;

                if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
                {
                    try
                    {
                        Console.Write("Введите первое число: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Введите второе число: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());

                        double result = 0;

                        switch (choice)
                        {
                            case "1":
                                result = calculator.Add(num1, num2);
                                Console.WriteLine($"Результат: {num1} + {num2} = {result}");
                                break;
                            case "2":
                                result = calculator.Subtract(num1, num2);
                                Console.WriteLine($"Результат: {num1} - {num2} = {result}");
                                break;
                            case "3":
                                result = calculator.Multiply(num1, num2);
                                Console.WriteLine($"Результат: {num1} × {num2} = {result}");
                                break;
                            case "4":
                                result = calculator.Divide(num1, num2);
                                Console.WriteLine($"Результат: {num1} ÷ {num2} = {result}");
                                break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: введите число!");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Неверный выбор!");
                }
            }

            Console.WriteLine("Спасибо за использование калькулятора!");
        }
    }

    public class Calculator
    {
        // Методы будут добавляться участниками команды
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            throw new NotImplementedException("Метод Subtract не реализован");
        }

        public double Multiply(double a, double b)
        {
            throw new NotImplementedException("Метод Multiply не реализован");
        }

        public double Divide(double a, double b)
        {
            throw new NotImplementedException("Метод Divide не реализован");
        }
    }
}