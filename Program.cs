using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uptime
{
    static class Program
    {
        private static bool avecAuMoinsUnJour;
        private static string gdf;

        public static string uptime(bool p)
        {
            int ticks;
            int sec;
            int min;
            int hour;
            int day;

            ticks = Environment.TickCount;
            sec = ticks / 1000;
            min = sec / 60;
            hour = min / 60;
            day = hour / 24;
            if (avecAuMoinsUnJour)
            {
                return string.Format("{0} Jours {1:00}:{2:00}:{3:00}", day, (hour % 24), (min % 60), (sec % 60));
            }
            else
            {
                return string.Format("{0} h {1:00} min {2:00} sec", hour, (min % 60), (sec % 60));
            }
        }

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("uptime started");
            do
            {
               

                Console.WriteLine(uptime(avecAuMoinsUnJour = true));
                Thread.Sleep(160000);

            } while (true);



            Console.WriteLine("uptime finish");
        }
        public static void sgd()
        {
            gdf = Console.ReadLine();
        }
    }
}
