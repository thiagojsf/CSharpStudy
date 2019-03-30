using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportTest
{
    public class Program
    {
        public static void Main(string[] args)
        {

            do
            {

                Console.WriteLine("Digite o código do aerporto que deseja consultar ou sair para encerrar o programa:");

                string codigoAeroporto = Console.ReadLine();

                if (codigoAeroporto == "SAIR")
                    break;

                var db = new AirportContext("Server=localhost;Initial Catalog=todanota;Integrated Security=True");

                //db.Database.Log = s => Console.WriteLine(s);

                var resultadoDB = db.Airports.Where(airport => airport.Code == codigoAeroporto);

                if (resultadoDB.Count() > 0)
                {
                    Console.WriteLine(resultadoDB.FirstOrDefault().Name);
                }
                else
                {
                    Console.WriteLine("Não existe um aeroporto com este código, deseja inserir (S/N)");

                    if(Console.ReadLine() == "S")
                    {
                        Console.WriteLine("Nome do aeroporto");
                        string nomeAeroporto = Console.ReadLine();

                        var aeroporto = new Airport()
                        {
                            Code = codigoAeroporto,
                            Name = nomeAeroporto,
                            CityId = 25666,
                            Disabled = false
                        };

                        db.Airports.Add(aeroporto);

                        db.SaveChanges();

                    }
                }

            } while (true);

        }
    }
}
