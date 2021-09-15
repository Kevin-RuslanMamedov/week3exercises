using System;

namespace WeatherReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsin kasutajalt mitu kraadi õues on;
            //kui õues on rohkem, kui 35 kraadi siis programm kuvab "boiling hot"
            //kui üues on 30 kuni 35 kraadi, programm kuvab "Hot"
            //kui õues on 20 kuni 30 kraadi, programm kuvab "Nice"
            //kui õues on 10 kuni 20 kraadi, programm kuvab "chilly"
            //kui õues on 0 kuni 10 kraadi, programm kuvab "cold"
            //kui õues on alla 0 kraadi, programm kuvab "freezing cold".
            
            Console.WriteLine("Mitu kraadi on õues?");
            int temp = Convert.ToInt32(Console.ReadLine());

            switch (temp)
            {
                case 35:
                    Console.WriteLine("Hot");
                    break;
                case 34:
                    Console.WriteLine("Hot");
                    break;
                case 33:
                    Console.WriteLine("Hot");
                    break;
                case 32:
                    Console.WriteLine("Hot");
                    break;
                case 31:
                    Console.WriteLine("Hot");
                    break;
                case 30:
                    Console.WriteLine("Hot");
                    break;
                case 29:
                    Console.WriteLine("Nice");
                    break;
                case 28:
                    Console.WriteLine("Nice");
                    break;
                case 27:
                    Console.WriteLine("Nice");
                    break;
                case 26:
                    Console.WriteLine("Nice");
                    break;
                case 25:
                    Console.WriteLine("Nice");
                    break;
                case 24:
                    Console.WriteLine("Nice");
                    break;
                case 23:
                    Console.WriteLine("Nice");
                    break;
                case 22:
                    Console.WriteLine("Nice");
                    break;
                case 21:
                    Console.WriteLine("Nice");
                    break;
                case 20:
                    Console.WriteLine("Nice");
                    break;
                case 19:
                    Console.WriteLine("Chilly");
                    break;
                case 18:
                    Console.WriteLine("Chilly");
                    break;
                case 17:
                    Console.WriteLine("Chilly");
                    break;
                case 16:
                    Console.WriteLine("Chilly");
                    break;
                case 15:
                    Console.WriteLine("Chilly");
                    break;
                case 14:
                    Console.WriteLine("Chilly");
                    break;
                case 13:
                    Console.WriteLine("Chilly");
                    break;
                case 12:
                    Console.WriteLine("Chilly");
                    break;
                case 11:
                    Console.WriteLine("Chilly");
                    break;
                case 10:
                    Console.WriteLine("Chilly");
                    break;
                case 9:
                    Console.WriteLine("Cold");
                    break;
                case 8:
                    Console.WriteLine("Cold");
                    break;
                case 7:
                    Console.WriteLine("Cold");
                    break;
                case 6:
                    Console.WriteLine("Cold");
                    break;
                case 5:
                    Console.WriteLine("Cold");
                    break;
                case 4:
                    Console.WriteLine("Cold");
                    break;
                case 3:
                    Console.WriteLine("Cold");
                    break;
                case 2:
                    Console.WriteLine("Cold");
                    break;
                case 1:
                    Console.WriteLine("Cold");
                    break;
                case 0:
                    Console.WriteLine("Cold");
                    break;
                case var _ when temp < 0:
                    Console.WriteLine("Freezing cold");
                    break;

            }

            if (temp >= 35)
            {
                Console.WriteLine("Boiling hot");
            }
            else if (temp >= 30 && temp < 35)
            {
                Console.WriteLine("Hot");
            }
            else if (temp >= 20 && temp < 30)
            {
                Console.WriteLine("Nice");
            }
            else if (temp >= 10 && temp <20)
            {
                Console.WriteLine("Chilly");
            }
            else if (temp >= 0 && temp <10)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("Freezing cold");
            }

        }   
    }
}
