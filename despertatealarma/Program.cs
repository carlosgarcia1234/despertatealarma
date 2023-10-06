using System;
using System.Threading;

namespace Alarm
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la hora de la alarma en formato HH:mm:ss");
            string inputTime = Console.ReadLine();

            if (DateTime.TryParse(inputTime, out DateTime alarmTime))
            {
                Console.WriteLine("Alarma establecida para las {0}", alarmTime.ToString("HH:mm:ss"));

                TimeSpan timeUntilAlarm = alarmTime - DateTime.Now;

                if (timeUntilAlarm.TotalSeconds > 0)
                {
                    Thread.Sleep(timeUntilAlarm);
                    Console.WriteLine("¡Despierta! Es hora de levantarse.");
                    Console.Beep(1000, 1000);
                }
                else
                {
                    Console.WriteLine("Lo siento, el tiempo de la alarma ya ha pasado.");
                }
            }
            else
            {
                Console.WriteLine("Formato de hora no válido. Por favor, inténtelo de nuevo en el formato HH:mm:ss");
            }

            Console.ReadLine();
        }
    }
}