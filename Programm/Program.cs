using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportNS;

namespace Programm
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto[] auto = new Auto[6];
            auto[0] = new Auto("Daewoo Matiz",     3.5, 1.5, 152.0,8.2, 60000.0, "Мини");
            auto[1] = new Auto("Peugeot 307 SW",   4.32,1.76,160.0,9.0, 80000.0, "Малый");
            auto[2] = new Auto("Kia Rio",          4.4, 1.74,185.0,7.2, 100000.0,"Средний");
            auto[3] = new Auto("Lada Kalina",      4.04,1.7, 165.0,9.7, 65000.0, "Малый");
            auto[4] = new Auto("Hyundai Accent",   4.42,1.68,165.0,10.6,85000.0, "Средний");
            auto[5] = new Auto("Mitsubishi Galant",4.63,1.74,180.0,9.3, 110000.0,"Большой");

            Console.WriteLine("В автопарке такси есть:");
            for (int i = 0; i < auto.Length; i++)
            {
                auto[i].ShowDim();
                Console.WriteLine("");
            }

            double AllCost = 0;
            for (int i = 0; i < auto.Length; i++)
            {                
                AllCost = AllCost + auto[i].cost;              
            }
            Console.WriteLine("Полная стоимость - {0} $",AllCost);
            Console.WriteLine("");

            Auto vrem = new Auto();
            for(int i = 0; i < auto.Length - 1; i++)
             for(int j = 0; j < auto.Length - 1; j++)
             {
                if (auto[j].expence > auto[j+1].expence)
                {
                        vrem = auto[j];
                        auto[j] = auto[j + 1];
                        auto[j + 1] = vrem;
                }
             }

            Console.WriteLine("Отсортированный:");
            for (int i = 0; i < auto.Length; i++)
            {
                auto[i].ShowDim();
                Console.WriteLine("");
            }

            int a, b;
            a = 160;
            b = 170;
            for (int i = 0; i < auto.Length; i++)
            {
                if(auto[i].speed>a && auto[i].speed<b)
                    Console.WriteLine("По заданному диапозону скорости ({0}-{1}) найден - {2}({3})", a,b,auto[i].Name,auto[i].speed);
            }
        }
    }
}
