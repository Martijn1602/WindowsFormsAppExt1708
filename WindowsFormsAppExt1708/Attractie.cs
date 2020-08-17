using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppExt1708
{
    class Attractie
    {
        public string naam { get; set; }
        public string kleur { get; set; }

        public int leeftijd { get; set; }
        public int maxPers { get; set; }
        public List<Persoon> leerlingen { get; set; } = new List<Persoon>();

        public Attractie(string jaar, string richting)
        {
            this.naam = naam;
            this.kleur = kleur;
            this.leeftijd = leeftijd;
            this.maxPers = maxPers;
        }

        public override string ToString()
        {
            return $"{naam}: {kleur}";

        }
    }
}
