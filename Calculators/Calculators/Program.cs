using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculators
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            char opt;
            int sum;
            Calculator calc = new Calculator();
            do
            {
                Console.Clear();
                Console.WriteLine("1. Введите 1,чтобы сложить два числа,которые вводятся через запятую;");
                Console.WriteLine("2. Введите 2,чтобы сложить произвольное количество чисел,которые вводятся через запятую;");
                Console.WriteLine("3. Введите 3,чтобы выполнялись два первых пункта + между числами может быть любой разделитель;");
                Console.WriteLine("4. Введите 4,чтобы выполнялись три первых пункта + числа должны быть сторого положительными;");
                Console.WriteLine("5. Введите 5,чтобы выполнялись четыре первых пункта + произвольная длина разделителей;");
                Console.WriteLine("6. Для выхода выберите режим Esc,для осуществления повторной операциии нажмите Enter");
                opt = Console.ReadKey().KeyChar;
                if (Int32.TryParse(opt.ToString(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("\nВы выбрали пункт {0},пожалуйста,введите строку аргументов:", option);
                            calc.str = Console.ReadLine();
                            sum = calc.AddTwoNumbers(calc.str);
                            Console.WriteLine("Сумма аргументов:{0}", sum);
                            break;
                        case 2:
                            Console.WriteLine("\nВы выбрали пункт {0},пожалуйста,введите строку аргументов:", option);
                            calc.str = Console.ReadLine();
                            sum = calc.AddAnyNumbers(calc.str);
                            Console.WriteLine("Сумма аргументов:{0}", sum);
                            break;
                        case 3:
                            Console.WriteLine("\nВы выбрали пункт {0},пожалуйста,введите строку аргументов:", option);
                            calc.str = Console.ReadLine();
                            sum = calc.AddAnyDivide(calc.str);
                            Console.WriteLine("Сумма аргументов:{0}", sum);
                            break;
                        case 4:
                            Console.WriteLine("\nВы выбрали пункт {0},пожалуйста,введите строку аргументов:", option);
                            calc.str = Console.ReadLine();
                            sum = calc.AddNotNegativeNumbers(calc.str);
                            Console.WriteLine("Сумма аргументов:{0}", sum);
                            break;
                        case 5:
                            Console.WriteLine("\nВы выбрали пункт {0},пожалуйста,введите строку аргументов:", option);
                            calc.str = Console.ReadLine();
                            sum = calc.AddAnyLongDivide(calc.str);
                            Console.WriteLine("Сумма аргументов:{0}", sum);
                            break;
                        case 6:
                            option = 0;
                            break;
                        default: option = 0; break;
                    }
                }
                else
                {
                    Console.WriteLine("\nВы ввели не число,пожалуйста,повторите ввод!");
                    if (opt == 27) option = 0;
                }
                Console.ReadKey();
            } while (option != 0);
        }
    }
}
