using System;
using System.Collections.Generic;

namespace Study.Students
{
    class IgorAfonso : Programmer
    {
        public IgorAfonso()
        {
            Name = "Igor Afonso Nunes";
            Birthday = new DateTime(1999, 01, 18);
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
                    Name = "Java",
                    IsFunctional = true,
                    IsOO = true
                },
                new Language
                {
                    Name = "HTML",
                    IsFunctional = false,
                    IsOO = false
                },
            };
        }
    }
}
