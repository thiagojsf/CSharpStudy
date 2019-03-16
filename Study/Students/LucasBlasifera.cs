using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Students
{
    class LucasBlasifera : Programmer
    {
        public LucasBlasifera()
        {
            Name = "Lucas Blasifera";
            Birthday = new DateTime(1997, 11, 26);
            PersonalAddress = new Address()
            {
                Street = "Av. Barão Homem de Melo",
                Number = 3280,
                ZipCode = "30494-080",
                City = "Belo Horizonte",
                Province = "Minas Gerais",
                Country = "Brasil"
            };
            Languages = new List<Language>
            {
                new Language
                {
                    Name = "C#",
                    IsFunctional = true,
                    IsOO = true
                },
                new Language
                {
                    Name = "Typescript",
                    IsFunctional = true,
                    IsOO = true
                }
            };
        }
    }
}
