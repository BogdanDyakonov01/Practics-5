using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    
    {
        static void Main(string[] args)
        {
            string[] inventory = { "Револьвер", "Записная книжка", "Отмычка", "Фляга виски", "Пачка сигарет" };
            string[] enemies = { "Осведомитель-карманник", "Гангстер с револьвером", "Босс синдиката" };
            int[] healths = { 30, 70, 120 };
            int[] damages = { 10, 25, 40 };
            int[] cluesFound = { 1, 4, 3, 7 };
            Console.WriteLine("Инвентарь сыщика:");
            foreach (var item in inventory)
            {
                Console.WriteLine("- " + item);
            }
            Console.WriteLine();
            int indexOfLockPick = Array.IndexOf(inventory, "Отмычка");
            if (indexOfLockPick != -1)
            {
                Console.WriteLine("Предмет <<Отмычка>> найден - можно взламывать сейф.");
            }
            else
            {
                Console.WriteLine("Отмычки нет - взлом невозможен.");
            }
            Console.WriteLine();
            int[] damageLog = new int[5];
            Random random = new Random();
            for (int i = 0; i < damageLog.Length; i++)
            {
                int shotDamage = random.Next(15, 36);
                damageLog[i] = shotDamage;
                Console.WriteLine($"Раунд {i + 1}: выстрел нанёс {shotDamage} урона.");
            }
            Console.WriteLine();
            int totalDamage = 0;
            for (int i = 0; i < damageLog.Length; i++)
            {
                totalDamage += damageLog[i];
            }
            Console.WriteLine($"Суммарный урон за бой: {totalDamage}");
            Console.WriteLine();
            int sumClues = 0;
            for (int i = 0; i < cluesFound.Length; i++)
            {
                sumClues += cluesFound[i];
            }
            double averageClues = (double)sumClues / cluesFound.Length;
            Console.WriteLine($"Среднее количество улик на район: {averageClues:F2}");
            Console.WriteLine();
            Array.Sort(damageLog);
            int worstShot = damageLog[0];
            int bestShot = damageLog[damageLog.Length - 1];
            Console.WriteLine("Урон выстрелов (отсортировано по возрастанию): " + string.Join(", ", damageLog));
            Console.WriteLine($"Лучший выстрел: {bestShot} урона.");
            Console.WriteLine($"Худший выстрел: {worstShot} урона.");
            Array.Reverse(damageLog);
            Console.WriteLine("Рейтинг раундов (по убыванию урона): " + string.Join(", ", damageLog));
            Console.ReadKey();
        }
    }
}
