namespace HobortosHorgasz
{
    class NagyHal : Hal
    {
        public NagyHal(double tomeg)
        {
            this.tomeg = tomeg;
            szalkasE = false;
        }

        public override bool Kifog()
        {
            if (SajatRandom.rnd.Next(1, 3) == 1)
                return true;
            return false;

        }
    }
}
