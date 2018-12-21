using System;

namespace TransportNS
{
    public class Auto : Transport
    {
        public string type;

        public Auto()
        {
            this.name = "";
        }
        
        public Auto(string n, double len, double wid, double spe, double exp, double cost, string tp) : base(n, len, wid, spe, exp, cost)
        {
            type = tp;
        }

        protected string Type
        {
            get { return type; }
            private set { name = value; }
        }

        public override void ShowDim()
        {
            Console.WriteLine("Имя: {0}\n Тип: {1}\n Длина: {2} метров Ширина: {3} метров \n Макс.скорость: {4} км/ч Расход(в городе): {5}л на 100/ч \nСтоимость: {6} $",
                Name, Type, Length, Width, Speed, Exp, Cost);
        }
    }
}
