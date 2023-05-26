using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");

            string str1 = "Hello ";
            string str2 = "world";

            Console.WriteLine(str1 + str2);


            Console.WriteLine();
            Console.WriteLine("Задание 2");

            Console.WriteLine("Введите 1 переменную: ");
            string c = Console.ReadLine();
            int a = int.Parse(c);

            Console.WriteLine("Введите 2 переменную: ");
            string h = Console.ReadLine();
            int b = int.Parse(h);

            Console.WriteLine("Сложение: " + (a + b));
            Console.WriteLine("Умножение: " + (a * b));
            Console.WriteLine("Вычитание: " + (a - b));
            Console.WriteLine("Деление: " + (a / b));


            Console.WriteLine();
            Console.WriteLine("Задание 3");

            Console.WriteLine("Введите Имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите Фамилию: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите Отчество: ");
            string dadname = Console.ReadLine();

            Console.WriteLine(name + " " + surname + " " + dadname);


            Console.WriteLine();
            Console.WriteLine("Задание 4");

            int playerHealth = 100;
            int playerDamage = 20;
            int playerDefense = 5;

            int monsterHealth = 50;
            int monsterDamage = 30;
            int monsterDefense = 3;

            int playerRealDamage = (int)Math.Round((double)monsterDamage / playerDefense);
            int monsterRealDamage = (int)Math.Round((double)playerDamage / monsterDefense);

            playerHealth -= monsterRealDamage;
            monsterHealth -= playerRealDamage;

            Console.WriteLine("Здоровье игрока: " + playerHealth);
            Console.WriteLine("Здоровье монстра: " + monsterHealth);
            Console.WriteLine("Урон игрока: " + playerRealDamage);
            Console.WriteLine("Урон монстра: " + monsterRealDamage);
        }
    }
}
