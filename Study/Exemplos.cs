using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Exemplos
    {
        public static void ExemploPerformanceStringBuilder()
        {
            var cronometro = new System.Diagnostics.Stopwatch();

            cronometro.Start();

            var palavra = "ihfsdhfjshfjshfksdhfkjsdhfkjsdhfksdhfksdhfksdjfhksdhfksdjfhksdjgf";

            var sb = new StringBuilder();

            for (var i = 0; i < 20000; i++)
            {
                sb.Append(palavra);
            }

            sb.ToString();

            Console.WriteLine(cronometro.ElapsedMilliseconds);
        }

        public static void ExemploIfDEBUGWarningLine()
        {
#if DEBUG
            Console.WriteLine("Estou na linha 194");
            Console.WriteLine("Goku passou na linha 195");

#endif
#line 400
#warning Não utilize este código
        }

        public static IEnumerable<int> ExemploYieldReturn()
        {
            for(var i = 0; i < 5000; i++)
            {
                int numeroAleatorio = new Random().Next(100000);
                yield return numeroAleatorio;
            }
        }
        
    }
}
