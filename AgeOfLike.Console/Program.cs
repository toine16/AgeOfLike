using AgeOfLike.Factory.Model.Batiment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfLike.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Forum ff = new Forum();
            Building maCaserne = ff.CreationCaserne();

            System.Console.WriteLine("Création d'une nouvelle " + maCaserne.GetType());
            System.Console.WriteLine("Abrite  " + maCaserne.Population);


            Caserne ca = ff.CreationCaserne();
            ca.CreationFantassin();

            maCaserne = ff.CreationMaison();
            System.Console.WriteLine("Création d'une nouvelle " + maCaserne.GetType());
            System.Console.WriteLine("Abrite  " + maCaserne.Population);


            System.Console.ReadKey();

        }
    }
}
