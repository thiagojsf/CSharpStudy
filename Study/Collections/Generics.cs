using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Collections
{
    public class Generics
    {
        public void Print<T>(T itemToPrint)
        {
            Console.WriteLine(itemToPrint);

            if (typeof(T) == typeof(string))
            {

            }
        }

        public void PrintClass<SA>(SA itemToPrint) where SA : class
        {
            Console.WriteLine(itemToPrint);
        }

        public void PrintStruct<J>(J itemToPrint) where J : struct
        {
            Console.WriteLine(itemToPrint);
        }

        public void PrintList()
        {
            /*
            Print(1);
            Print("Hello world!");
            Print(false);
            PrintClass(1);
            PrintClass(new Programmer());
            PrintIEnumerable(new Programmer());
            PrintIEnumerable(new Programmer());
            PrintStruct(1);
            PrintStruct("Hello world!");
            PrintStruct(false);
            */
            
        }
    }
}
