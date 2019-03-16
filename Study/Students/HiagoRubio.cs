using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Students
{
    public class HiagoRubio : JavaScriptDeveloper
    {
        public HiagoRubio()
        {
            Name = "Hiago Marques Rubio";
            Birthday = new DateTime(1994, 02, 12);
            PersonalAddress = new Address()
            {
                Street = "Rua Javaés",
                Number = 500,
                ZipCode = "31530-303",
                City = "Belo Horizonte",
                Province = "Minas Gerais",
                Country = "Brasil"
            };
            Languages = new List<Language>
            {
                new Language
                {
                    Name = "Java",
                    IsFunctional = true,
                    IsOO = true
                },
                new Language
                {
                    Name = "JavaScript",
                    IsFunctional = true,
                    IsOO = true
                },
                  new Language
                {
                    Name = "4GL",
                    IsFunctional = false,
                    IsOO = false
                },
            };
        }
    }
}