using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Алёткина_2
{
    internal class Program
    {
        static void Main()
        {
            string name;
            string surname;
            string animal;
            string sign;
            System.Console.WriteLine("Введите ваше имя: ");
            name = System.Console.ReadLine();
            System.Console.WriteLine("Введите вашу фамилию и отчество: ");
            surname = System.Console.ReadLine();
            System.Console.WriteLine("Введите ваше любимое животное: ");
            animal = System.Console.ReadLine();
            System.Console.WriteLine("Введите ваш знак задиака: ");
            sign = System.Console.ReadLine();
            System.Console.WriteLine($"Индивидуальный гороскоп для пользователя {name} {surname}");
            System.Console.WriteLine($"Кем вы были в прошлой жизни: {animal}");
            System.Console.WriteLine($"Ваш знак задиака - {sign} ,поэтому вы - тонко чувствующая натура");
            System.Console.WriteLine("Для завершения сеанса нажмите ENTER.");
            System.Console.ReadLine();


        }
    }
}
