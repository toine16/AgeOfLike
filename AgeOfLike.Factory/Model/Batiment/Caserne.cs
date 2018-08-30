using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfLike.Factory.Batiment.Commun
{
    public class Caserne
    {
        public int Bois { get; set; }
        public int Pierre { get; set; }

        public Caserne()
        {
            Bois = 200;
            Pierre = 150;
        }
    }
}
