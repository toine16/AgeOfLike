using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfLike.Factory.Model.Batiment
{
    public class Maison : Building
    {
        public Maison()
        {
            Bois = 50;
            Pierre = 35;
            Population = 20;
            Vie = 100;
        }
    }
}
