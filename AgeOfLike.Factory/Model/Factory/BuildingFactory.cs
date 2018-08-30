using AgeOfLike.Factory.Model.Batiment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfLike.Factory.Model.Factory
{
    public abstract class BuildingFactory : Building
    {       
        public abstract Caserne CreationCaserne();
        public abstract Forum CreationForum();
        public abstract Maison CreationMaison();
        public abstract Building CreationBuilding();
    }
}
