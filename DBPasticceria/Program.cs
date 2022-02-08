using System;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using DBPasticceria.Model;

namespace Pasticceria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new DBPasticceria.Model.PASTICCERIAContext("FAGNI-NB02");

            var ricetteDefinite = from ricette in db.Ricette
                                  from dolci in db.Dolci
                                  from ingredienti in db.Ingredienti
                                  where dolci.CodD == ricette.CodD
                                  where ingredienti.CodI == ricette.CodI
                                  select new
                                  {
                                      nomeDolce = dolci.Nome,
                                      nomeIngrediente = ingredienti.Nome,
                                      quantità = ricette.QtaIngredienti + " " + ingredienti.Um
                                  };




            foreach (var obj in ricetteDefinite)
            {
                Console.WriteLine(obj.nomeDolce + " - " + obj.nomeIngrediente + ": " + obj.quantità);
            }

            /*
            Vetrina nuovo = new Vetrina();

            nuovo.CodD = 1;
            nuovo.Data = DateTime.Now;

            db.Vetrina.Add(nuovo);
            */

            Vetrina nuovo = new Vetrina();
            nuovo.CodD = 1;
            nuovo.Data = DateTime.Now;

            db.Vetrina.Add(nuovo);

            db.SaveChanges();

            Console.ReadLine();
        }
    }
}
