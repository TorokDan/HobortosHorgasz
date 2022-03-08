namespace HobortosHorgasz
{
    delegate void KifogvaKezelo(IKifoghato kifogott);
    delegate void EluszottKezelo(IKifoghato eluszott);
    class Horgasz
    {
        private int zsakDb = 0;
        private IKifoghato[] zsak;


        public Horgasz(int zsakMeret)
        {
            zsak = new IKifoghato[zsakMeret];
        }

        public KifogvaKezelo Kifogva;
        public EluszottKezelo Eluszott;

        public void Pecaz(IKifoghato kifogott)
        {
            if (zsakDb == zsak.Length)
                throw new System.Exception("Megtelt a zsák");
            else if (kifogott.Kifog() == true)
            {
                zsak[zsakDb++] = kifogott;
                Kifogva?.Invoke(kifogott);
            }
            else
                Eluszott?.Invoke(kifogott);
        }
        public bool AsszonyHaragszik()
        {
            bool vissza = false;
            if (zsakDb == 0)
                vissza = true;
            if (VanAranyhal())
                vissza = false;
            if (VanCsizma() && OsszTomeg() < 10)
                vissza = true;
            return vissza;
        }

        private double OsszTomeg()
        {
            int szamlalo = 0;
            double osszeg = 0;
            while (szamlalo < zsakDb)
                osszeg += zsak[szamlalo++].Tomeg;
            return osszeg;
        }
        private bool VanAranyhal()
        {
            for (int i = 0; i < zsakDb; i++)
                if (zsak[i] is KisHal && ((KisHal)zsak[i]).AranyhalE)
                    return true;
            return false;
        }
        private bool VanCsizma()
        {
            int szamlalo = 0;
            while (szamlalo <= zsakDb && !(zsak[szamlalo] is Gumicsizma))
                szamlalo++;
            return szamlalo <= zsakDb;
        }
    }
}
