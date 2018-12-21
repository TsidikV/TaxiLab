using System;

namespace TransportNS
{
    public abstract class Transport
    {
        public string name;
        public double length;
        public double width;
        public double speed;
        public double expence;
        public double cost;

        public Transport()
        {
            this.name = "";
        }

        public Transport(string n, double len, double wid, double spe, double exp, double cost)
        {
            this.name = n;
            this.length = len;
            this.width = wid;
            this.speed = spe;
            this.expence = exp;
            this.cost = cost;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        protected double Length
        {
            get { return length; }
            private set { length = value < 0 ? -value : value; }
        }

        protected double Width
        {
            get { return width; }
            private set { width = value < 0 ? -value : value; }
        }

        protected double Speed
        {
            get { return speed; }
            private set { speed = value < 0 ? -value : value; }
        }

        protected double Exp
        {
            get { return expence; }
            private set { expence = value < 0 ? -value : value; }
        }

        protected double Cost
        {
            get { return cost; }
            private set { cost = value < 0 ? -value : value; }
        }

        public virtual void ShowDim()
        {
            Console.WriteLine(" Имя: {0}\n Длина: {1} метра/(-ов) \n Ширина: {2} метра/(-ов) \n Макс.скорость: {3} km/h \n Расход: {4} л на 100km/h \n Стоимость: {5} $",
                Name, Length, Width, Speed, Exp, Cost);
        }
    }
}
