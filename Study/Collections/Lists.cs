using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Collections
{
    public class Lists
    {
        List<int> ListaInteiros;
        //List<T> ListaIndefinida;
        List<object> ListaObjetos;

        public Lists()
        {
            var listaInteiros = new List<int>();

            var lista = new List<OOProgrammer>
            {
                new JavaProgrammer()
                {
                    Name = "Hugo",
                    CoffeeCupsPerDay = 15
                },
                new CSharpProgrammer()
                {
                    Name = "Igor",
                    CoffeeCupsPerDay = 1
                },
                new TypeScriptProgrammer()
                {
                    Name = "Marcos",
                    CoffeeCupsPerDay = 3
                },
                new CPlusPlusProgrammer()
                {
                    Name = "Hugo",
                    CoffeeCupsPerDay = 50
                }
            };

            lista.Add(new TypeScriptProgrammer());

            var listaHugos = lista.Where(programmer => programmer.Name == "Hugo");
            var listaNomesOrdenados = lista.OrderBy(programmer => programmer.Name);
            var listaNomesOrdenadosDecrescente = lista.OrderByDescending(programmer => programmer.Name);
            var primeiroProgramador = lista.FirstOrDefault();
            var ultimoProgramador = lista.LastOrDefault();
            var existeMarcos = lista.Any(programmer => programmer.Name.Contains("cos"));
            var totalDeCafesPorDia = lista.Sum(programmer => programmer.CoffeeCupsPerDay);

        }
    }
}
