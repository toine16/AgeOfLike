using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfLike.Factory.Model
{
    public class Ressources
    {
        public Ressources()
        {
            Or = 100;
            OrMax = 1000;
            Nourriture = 100;
            NourritureMax = 1000;
            Bois = 400;
            BoisMax = 1000;
            Pierre = 400;
            PierreMax = 1000;
            Population = 5;
            PopulationMax = 50;
        }

        public int Or { get; set; }
        public int Nourriture { get; set; }
        public int Bois { get; set; }
        public int Pierre { get; set; }
        public int Population { get; set; }
        public int OrMax { get; set; }
        public int NourritureMax { get; set; }
        public int BoisMax { get; set; }
        public int PierreMax { get; set; }
        public int PopulationMax { get; set; }
    }
}
