using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HobortosHorgasz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Horgasz horgasz = new Horgasz(4);
            horgasz.Kifogva += KiirSiker;
            horgasz.Eluszott += KiirKudarc;


            Gumicsizma csizma = new Gumicsizma();
            KisHal kishal = new KisHal(3);
            NagyHal nagyhal = new NagyHal(3);


            horgasz.Pecaz(csizma);
            horgasz.Pecaz(kishal);
            horgasz.Pecaz(nagyhal);
            horgasz.Pecaz(kishal);

            Console.WriteLine($"Asszony haragszik: {horgasz.AsszonyHaragszik()}");

        }
        public static void KiirSiker(IKifoghato kifogott)
        {
            Console.WriteLine($"{kifogott} Sikeresen kifogva");
        }
        public static void KiirKudarc(IKifoghato eluszott)
        {
            Console.WriteLine($"{eluszott} Nem lett kifogva");
        }
    }
}
