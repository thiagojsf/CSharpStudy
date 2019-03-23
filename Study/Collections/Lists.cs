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
        List<string> ListaObjetos;

        public Lists()
        {
            var listaInteiros = new List<char>();
            //listaInteiros.Add(800);
            listaInteiros.Add('T');
            //listaInteiros.RemoveAt(0);
            var listaDeErres = listaInteiros.Where(y => y == 'R');

            if (listaInteiros.Count() > 0)
            {
                return;
            }
            else 
                if (listaInteiros.Count() > 3)
                {
                    listaInteiros.Add('Y');
                    listaInteiros.Add('Z');
                }
                else
                {

                }
            
            

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
