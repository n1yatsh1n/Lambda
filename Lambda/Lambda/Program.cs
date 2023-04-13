using System;

namespace Lambda
{
  internal class Program
    {
        
        delegate void ActionMath(double number_1, double number_2, double number_3);

        public static void Main()
        {
            Console.Clear();
            ActionMath minimum = (double number_1, double number_2, double number_3) =>
            {
                Console.WriteLine(Math.Min(number_1, Math.Min(number_2, number_3)));
            };
            ActionMath maximum = (double number_1, double number_2, double number_3) =>
            {
                Console.WriteLine(Math.Max(number_1, Math.Max(number_2, number_3)));
            };
            ActionMath summa = (double number_1, double number_2, double number_3) =>
            {
                Console.WriteLine(number_1 + number_2 + number_3);
            };
            ActionMath multiplication = (double number_1, double number_2, double number_3) =>
            {
                Console.WriteLine(number_1 * number_2 * number_3);
            };
            ActionMath arithmeticMean = (double number_1, double number_2, double number_3) =>
            {
                Console.WriteLine((number_1 + number_2 + number_3)/3);
            };
            Console.WriteLine("Введите первое число:");
            var inputData_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            var inputData_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            var inputData_3 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("1. Минимальное значение\n" +
                              "2. Максимальное значение\n" +
                              "3. Сумма чисел\n" +
                              "4. Произведение чисел\n" +
                              "5. Среднее арифметическое чисел\n" +
                              "6. Выход");
            ConsoleKey inputBtn = Console.ReadKey().Key;
            switch (inputBtn)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    minimum(inputData_1, inputData_2, inputData_3);
                    Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    Main();
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    maximum(inputData_1, inputData_2, inputData_3);
                    Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    Main();
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    summa(inputData_1, inputData_2, inputData_3);
                    Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    Main();
                    break;
                case ConsoleKey.D4:
                    Console.Clear();
                    multiplication(inputData_1, inputData_2, inputData_3);
                    Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    Main();
                    break;
                case ConsoleKey.D5:
                    Console.Clear();
                    arithmeticMean(inputData_1, inputData_2, inputData_3);
                    Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
                    Console.ReadKey();
                    Main();
                    break;
                case ConsoleKey.D6:
                    Console.Clear();
                    Console.WriteLine("До свидания!");
                    break;
            }
            

            
            
            

            
            
            
            
            

        }
    }
}