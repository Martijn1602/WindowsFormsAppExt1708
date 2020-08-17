using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppExt1708
{
    class Pretpark
    {
        public string Naam { get; set; }
        public string Werknemers { get; set; }

        public string Attracties { get; set; }

        public List<Attractie> attractielijst { get; set; } = new List<Attractie>();
        public List<Werknemer> werknemerlijst { get; set; } = new List<Werknemer>();


        public Pretpark(string naam, string werknemers, string attracties)
        {
            Naam = naam;
            Werknemers = werknemers;
            Attracties = attracties;
        }

        public Pretpark()
        {
        }

        public override string ToString()
        {
            return Naam;
        }

    }
}
