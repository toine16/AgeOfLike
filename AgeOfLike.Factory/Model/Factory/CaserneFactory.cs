using AgeOfLike.Factory.Model.Unites;
using AgeOfLike.Factory.Unites.Commun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfLike.Factory.Model.Factory
{
    public interface  CaserneFactory
    {
        Fantassin CreationFantassin();
        Piquier CreationPiquier();

    }
}
