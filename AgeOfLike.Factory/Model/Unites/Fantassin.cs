﻿using AgeOfLike.Factory.Model.Unites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfLike.Factory.Unites.Commun
{
    public class Fantassin : Soldat
    {

        public Fantassin()
        {
            Vie = 12;
            Attaque = 4;
            Defense = 3;
        }

        public override string ToString()
        {
            return "Fantassin";
        }
    }
}
