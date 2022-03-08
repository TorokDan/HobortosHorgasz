namespace HobortosHorgasz
{
    class Gumicsizma : IKifoghato
    {
        protected double tomeg = 0.5;

        public double Tomeg { get => tomeg; }

        public bool Kifog() => true;
    }
}
