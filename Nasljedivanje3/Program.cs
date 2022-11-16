using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje3
{
    class Bilijka
    {
        bool opadajuListovi;
        public bool OpadajuListovi { get => opadajuListovi; set => opadajuListovi = value; }
        public void Stablo(bool OL)
        {
            this.OpadajuListovi = OL;
        }
    }
    class Stablo : Bilijka
    {
        
    }
    class Cvijet : Bilijka
    {
        public Cvijet(bool OL)
        {
            this.OpadajuListovi = OL;
        }
}
    class Bijelogoricno : Stablo
    {
        public Bijelogoricno(bool OL)
        {
            this.OpadajuListovi = OL;
        }
    }
    class Crnogoricno : Stablo
    {
        public Crnogoricno(bool OL)
        {
            this.OpadajuListovi = OL;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bijelogoricno Hrast = new Bijelogoricno(true);
            Crnogoricno Bor = new Crnogoricno(false);
            Console.WriteLine("Hrast listove padaju su " + Hrast.OpadajuListovi + ".");
            Console.WriteLine("\r\nBor listove padaju su " + Bor.OpadajuListovi + ".");
            Console.ReadKey();
        }
    }
}
