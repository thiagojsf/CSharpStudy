using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class Program
    {
        class Teste1
        {
            int X;
            int Y;
            public Teste1()
            {
                X = 10;
                Y = 20;
            }
        }

        struct Teste2
        {
            int X;
            int Y;
            /*
            public Teste2()
            {
                X = 10;
                Y = 20;
            }
            */
        }

        static void Main(string[] args)
        {
            /*
            Computer computer = new Computer();
            computer.CPU = "i7";

            OOProgrammer oo = new TypeScriptProgrammer();
            OOProgrammer oo2 = new OOProgrammer();



            Person pessoa = new Person();

            //int idade = pessoa.CalculateAge();

            int idade = Person.CalculateAge(pessoa);



    */

            Person igor = Person.GetPersonWith20YearsOld();
            igor.Name = "Igor";
            igor.Age = 24;
            int r = igor.Age;

            igor.CoffeeCupsPerDay = 10;

            double valorPIS = ImpostoPIS.CalcularPIS(35000);


            string integrantes = "Ana " + " Val" + igor.Name + "Letícia " + "Igor";
            string integrantew = string.Format("Ana Val {0} {1} Letícia Igor", igor.Name, igor.Name);
            string integranter = $"Ana Val {igor.Name} Letícia Igor";










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


            using (var stream = new FileStream("", FileMode.Append))
            {

            }

            Programmer programador = new Programmer
            {
                Name = "Bruno",
                Age = 22
            };


        }
    }
}
