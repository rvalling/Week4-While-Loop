using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            //siis mängu võidab arvuti.
            //programm genereerib juhuslikku numbrit ühte korda.

            Random rnd = new Random();
            int i = 0;

            while (i < 3)
            {
                int cpuNumber = rnd.Next(1, 11);
                Console.WriteLine("Sisesta number:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Oled võitnud! Palju õnne!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale number. {3 - i} katset on jäänud.");
                }
                Console.WriteLine("Kena päeva!");
            }
        }
    }
}
