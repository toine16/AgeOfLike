using AgeOfLike.Factory.Model.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfLike.Factory.Model.Batiment
{
    public class Forum : BuildingFactory
    {
        public Forum()
        {
            Bois = 500;
            Pierre = 800;
            Population = 30;
            Vie = 400;
        }

        public override Building CreationBuilding()
        {
            return new Building();
        }

        public override Caserne CreationCaserne()
        {
            return new Caserne();
        }

        public override Forum CreationForum()
        {
            return new Forum();
        }

        public override Maison CreationMaison()
        {
            return new Maison();
        }

        public override string ToString()
        {
            return "Forum";
        }
    }
}
