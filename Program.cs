using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int age;
             Console.Write("Введите ваш возраст: ");
             age = Convert.ToInt32( Console.ReadLine());
             if (age >= 18) 
             {
                 Console.WriteLine("Добро пожаловать в наш бар!");
                 Console.WriteLine("Что будете пить?");
             }
             else 
             {
                 Console.WriteLine($"ВЫ слишком юнны приходите к нам через {18 - age}");
             }*/

            /* string dayOfWeek;
             Console.Write("Введите день недели: ");
             dayOfWeek = Console.ReadLine();

             if (dayOfWeek == "понедельник")//
             {
                 Console.WriteLine("Проходите курсы!");
             }
              else if (dayOfWeek == "вторник") // кода не продолжает проверки при одном верном блоке if
             {
                 Console.WriteLine("делаем домашнюю работу");
             }*/

            // Логическое И &&
            // x | y | x && y false -> 1 true -> 0
            //Таблица истинности левое выражениме записывается в х 
            //правое в у и затем формально перемножается получая на выходе 
            //true или false 
            // 1 | 1 | true -> 1
            // 1 | 0 | false -> 0
            // 0 | 1 | false -> 0
            // 0 | 0 | false -> 0

            // Логическое ИЛИ ||
            // для сочетания в логическом или хотя бы одна
            // единица будет давать true
            // x | y | x && y false -> 1 true -> 0
            // 1 | 1 | true -> 1
            // 1 | 0 | true -> 1
            // 0 | 1 | true -> 1
            // 0 | 0 | false -> 0

            /*int money = 500;
            int level = 10;

            if (money >= 500 || level > 9)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("not enoth");
            }*/

            /*string dayOfWeek1;
            Console.Write("Введите день недели: ");
            dayOfWeek1 = Console.ReadLine();

            switch (dayOfWeek1)
            {
                case "monday":
                    Console.WriteLine("идем в кино");
                    break;
                case "Tuesday":
                    Console.WriteLine("идем домой");
                    break;
                case "Wednesday":
                    Console.WriteLine("идем в кино");
                    break;
                case "Thursday":
                case "Friday":
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("идем домой");
                    break;
                default:
                    Console.WriteLine("нет");
                    break; 
        }*/
            /* string password = "123qwe";
             string userInput;

             Console.Write("Введите пароль: ");

             userInput = Console.ReadLine();

             if (userInput == password)
             {
                 Console.WriteLine("passowrd write");
             }
             else 
             {
                 Console.WriteLine("password wrong");
             }*/

            float rubelInWallet;
            float dollarsInWallet;

            int rubToUsd = 64, dollarsToUsd = 66;

            float exchangeCurrencyCount;

            string desiredOperation;

            Console.WriteLine("Добро пожаловать в обменник валют!");

            Console.Write("Введите баланс рублей: ");
            rubelInWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс долларов: ");
            dollarsInWallet = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Выберите необходимую операцию: ");
            Console.WriteLine("1 - обменять рубли на доллары. ");
            Console.WriteLine("2 - обменять доллары на рубли. ");
            Console.Write("Ваш выбор: ");
            desiredOperation = Console.ReadLine();

            switch (desiredOperation)
            {
                case "1":
                    Console.WriteLine("ОБмен рублей на доллары");
                    Console.Write("Сколько вы хотите обменять?: ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if(rubelInWallet >= exchangeCurrencyCount) 
                    { 
                    rubelInWallet -= exchangeCurrencyCount;
                    dollarsInWallet += exchangeCurrencyCount * rubToUsd;
                    }
                    else 
                    {
                        Console.WriteLine("не допустимое колличество рублей.");
                    }
                    break;
                case "2":
                    Console.WriteLine("Обмен доллары на рубли");
                    Console.Write("Сколько вы хотите обменять?: ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (dollarsInWallet >= exchangeCurrencyCount)
                    {
                        dollarsInWallet -= exchangeCurrencyCount;
                        rubelInWallet += exchangeCurrencyCount * dollarsToUsd;
                    }
                    else
                    {
                        Console.WriteLine("не допустимое колличество долларов.");
                    }
                    break;
                default:
                    Console.WriteLine("не верная операция");
                    break;
            }
            Console.WriteLine($"Ваш балланс {rubelInWallet} рублей, {dollarsInWallet} долларов.");
        }
    }
}
