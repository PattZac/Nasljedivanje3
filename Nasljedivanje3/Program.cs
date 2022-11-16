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
        public Bilijka(bool oL)
        {
            this.OpadajuListovi = oL;
        }
    }
    class Stablo : Bilijka
    {
        public Stablo(bool oL) : base(oL)
        {
            this.OpadajuListovi = oL;
        }
    }
    class Cvijet : Bilijka
    {
        public Cvijet(bool oL) : base(oL)
        {
            this.OpadajuListovi = oL;
        }
    }
    class Bijelogoricno : Stablo
    {
        public Bijelogoricno(bool oL) : base(true)
        {
            this.OpadajuListovi = oL;
        }
    }
    class Crnogoricno : Stablo
    {
        public Crnogoricno(bool oL) : base(false)
        {
            this.OpadajuListovi = oL;
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
