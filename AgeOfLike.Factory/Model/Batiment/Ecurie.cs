using AgeOfLike.Factory.Model.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgeOfLike.Factory.Model.Unites;

namespace AgeOfLike.Factory.Model.Batiment
{
    public class Ecurie : Building
    {
        public Ecurie()
        {
            Bois = 300;
            Pierre = 250;
            Vie = 300;
        }

        public Cavalier CreationCavalier()
        {
            return new Cavalier();
        }
    }
}
