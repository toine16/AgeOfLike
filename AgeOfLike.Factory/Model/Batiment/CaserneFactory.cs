﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfLike.Factory.Batiment.Commun
{
    public abstract class CaserneFactory
    {
        public abstract Fantassin CreationFantassin();
        public abstract Piquier CreationPiquier();
    }
}