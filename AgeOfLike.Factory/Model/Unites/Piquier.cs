using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfLike.Factory.Batiment.Commun
{
    public class Piquier : Soldat
    {

        public Piquier()
        {
            Vie = 14;
            Attaque = 2;
            Defense = 4;
        }

        public override Soldat Combattre(Soldat ennemi)
        {
            throw new NotImplementedException();
        }
    }
}
