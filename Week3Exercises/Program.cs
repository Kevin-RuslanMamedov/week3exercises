using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisse astumiseks:
            //miinimum matemaatikas 85 punkti;
            //miinimum keemias 90 punkti;
            //miinimum bioloogias 95 punkti;
            //programm küsib kasutajalt sisestada tema eksami punktid ja otsustab, kas kasutaja saab arstiks õppida

            Console.WriteLine("Sisesta enda matemaatika eksami punktid");
            int Matemaatikapunktid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisesta enda keemia eksami punktid");
            int Keemiapunktid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisesta enda bioloogia eksami punktid");
            int Bioloogiapunktid = Convert.ToInt32(Console.ReadLine());

            if (Matemaatikapunktid >= 85 && Keemiapunktid >= 90 && Bioloogiapunktid >= 95)
            {
                Console.WriteLine("Palju õnne sul on piisavalt punkte, et arstiks õppida");
            }
            else
            {
                Console.WriteLine("Kahjuks sina ei saanud piisavalt punkte, et arstiks õppida");
            }



        }
    }
}
