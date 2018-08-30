using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfLike.Factory.Unites.Commun
{
    public abstract class Soldat
    {
        public int Vie { get; set; }
        public int Attaque { get; set; }
        public int Defense { get; set; }
        public int Or { get; set; }
        public int Nourriture { get; set; }

        public abstract Soldat Combattre(Soldat ennemi);
        public bool EstEnVie()
        {
            if(Vie >= 1)
            {
                return true;
            }
            return false;
        }
    }
}
