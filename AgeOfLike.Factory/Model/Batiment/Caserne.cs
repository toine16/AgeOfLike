using AgeOfLike.Factory.Model.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgeOfLike.Factory.Model.Unites;
using AgeOfLike.Factory.Unites.Commun;

namespace AgeOfLike.Factory.Model.Batiment
{
    public class Caserne : Building
    {
        public Caserne()
        {
            Bois = 200;
            Pierre = 150;
            Vie = 200;
        }

        public Fantassin CreationFantassin()
        {
            return new Fantassin();
        }

        public Piquier CreationPiquier()
        {
            return new Piquier();
        }

        public override string ToString()
        {
            return "Caserne";
        }
    }
}
