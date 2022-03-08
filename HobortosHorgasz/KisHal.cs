namespace HobortosHorgasz
{
    class KisHal : Hal
    {
        protected bool aranyhalE = false;

        public bool AranyhalE { get => aranyhalE; }

        public KisHal(double tomeg)
        {
            this.tomeg = tomeg;
        }
        public KisHal(double tomeg, bool aranyhalE) 
            : this(tomeg)
        {
            this.aranyhalE = aranyhalE;
        }
    }
}
