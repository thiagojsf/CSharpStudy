using DataAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Study
{
    class Program
    {
        #region Classes

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

        public enum Cores
        {
            Preta,
            Azul,
            Verde
        }

        #endregion

        #region Estrturas

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

        #endregion

        #region Métodos estáticos

        #region Método main

        static void Main(string[] args)
        {

            /*

            Person igor = Person.GetPersonWith20YearsOld();
            igor.Name = "Igor";
            igor.Age = 24;
            int r = igor.Age;

            igor.CoffeeCupsPerDay = 10;

            double valorPIS = ImpostoPIS.CalcularPIS(35000);


            string integrantes = "Ana " + " Val" + igor.Name + "Letícia " + "Igor";
            string integrantew = string.Format("Ana Val {0} {1} Letícia Igor", igor.Name, igor.Name);
            string integranter = $"Ana Val {igor.Name} Letícia Igor";
            */


            //Study.Exemplos.ExemploPerformanceStringBuilder();


            //Study.Exemplos.ExemploIfDEBUGWarningLine();


            //var dataSet = Automotivo.Roda.CarregarDataTableRodas();

            DataAccess.Exemplos.ExemploCarregarDadosDB();

            DataAccess.Exemplos.ExemploGravacaoNoBanco();

            //AutomotivoFramework.Exemplos.ExemploCriacaoTapetes();

            var listaNumerosAleatorio = ExemploYieldReturn();

            for(var i = 0; i < 1000; i++)
            {
                Console.WriteLine(listaNumerosAleatorio.ElementAt(i));
            }

            Thread.Sleep(3000);

        }
        #endregion
        public static void TestAttribute()
        {
            Programmer.GetAttribute(typeof(CSharpProgrammer));
        }
        #endregion

        public static IEnumerable<int> ExemploYieldReturn()
        {
            for (var i = 0; i < 5000; i++)
            {
                int numeroAleatorio = new Random().Next(100000);
                yield return numeroAleatorio;
            }
        }
    }
}
