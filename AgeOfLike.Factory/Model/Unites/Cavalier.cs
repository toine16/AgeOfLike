using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfLike.Factory.Model.Unites
{
    public class Cavalier : Soldat
    {
        public Cavalier()
        {
            Vie = 20;
            Attaque = 7;
            Defense = 2;
        }
        public override Soldat Combattre(Soldat ennemi)
        {
            throw new NotImplementedException();
        }
    }
}
