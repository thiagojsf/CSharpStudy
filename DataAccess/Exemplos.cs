using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Exemplos
    {
        public static void ExemploCarregarDadosDB()
        {

            string idRoda = Console.ReadLine();

            var dataTable = DataAccess.DbHelper.GetDataTableFromSQL("SELECT * FROM RODA WHERE RodaId=" + idRoda);

            foreach(System.Data.DataRow row in dataTable.Rows)
            {
                Console.WriteLine(Convert.ToInt32(row[0]));
                Console.WriteLine(row["Aro"].ToString());
            }

        }

        public static void ExemploGravacaoNoBanco()
        {
            string comentario = Console.ReadLine();
            DbHelper.ExecuteQuery($"INSERT INTO COMENTARIO VALUES ('{comentario}')");
        }

    }
}
