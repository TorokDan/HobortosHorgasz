namespace HobortosHorgasz
{
    abstract class Hal : IKifoghato
    {
        protected double tomeg;
        protected bool szalkasE;

        public double Tomeg { get => tomeg; }
        public bool SzalkasE { get => szalkasE; }

        virtual public bool Kifog() => true;
    }
}
