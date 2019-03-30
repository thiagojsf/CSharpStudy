using Automotivo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AutomotivoFramework
{
    public class Exemplos
    {
        public static void ExemploCriacaoTapetes()
        {
            var db = new DbMap("Data Source=localhost;Initial Catalog=cars;Integrated Security=True");
            db.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            db.Tapetes.Add(new Tapete()
            {
                IndicaTapeteBorracha = true,
                Logs = new List<Log>()
                {
                    new Log()
                    {
                        Texto = "Oi"
                    }
                }

            });
            /*
            db.Logs.Add(new Log()
            {
                Texto = "Oi"
            });
            */

            db.SaveChanges();
        }

        public static void ExemploRecuperacaoDados()
        {
            var db = new DbMap("Data Source=localhost;Initial Catalog=cars;Integrated Security=True");

            var tapetes = db.Tapetes.Take(3);

            var tapetesLinq = from tapete in db.Tapetes
                              where tapete.IndicaTapeteBorracha
                              select tapete;

        }
    }
}
