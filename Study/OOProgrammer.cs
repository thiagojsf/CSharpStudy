using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public abstract class OOProgrammer : Programmer
    {
        public OOProgrammer()
        {
            AddDefaultLanguage();
        }

        public abstract void AddDefaultLanguage();

        public static IEnumerable<int> CarregarListaNumeros(int numeroMaximo)
        {
            for (var i = 0; i < numeroMaximo; i++)
            {
                yield return i;
            }
        }

        /// <summary>DoWork is a method in the TestClass class.
        /// <para>Here's how you could make a second paragraph in a description. <see cref="System.Console.WriteLine(System.String)"/> for information about output statements.</para>
        /// <seealso cref="TestClass.Main"/>
        /// </summary>
        public static void Teste()
        {
            var lista = CarregarListaNumeros(1000);

            for (var i = 0; i < lista.Count(); i++)
            {
                Console.WriteLine(i);
            }

        }

    }
}
