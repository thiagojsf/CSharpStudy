using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Person
    {



        #region Internal classes and structs
        public struct Address
        {
            public string Street;
            public int Number;
            public string ZipCode;
            public string City;
            public string Province;
            public string Country;
        }
        #endregion

        #region Properties
        public string Name;
        protected DateTime Birthday;
        public Address PersonalAddress;
        Vehicle Vehicle;
        public int Age
        {
            get
            {
                int age = DateTime.Today.Year - Birthday.Year;

                if (Birthday > DateTime.Today.AddYears(-age))
                    age--;

                return age;
            }
            set
            {
                this.Birthday = DateTime.Today.AddYears(value);
            }
        }
        public int CoffeeCupsPerDay { get; set; }
        #endregion

        public int CalculateAge()
        {
            this.Birthday = DateTime.Now;
            return this.Age;
        }

        public static int CalculateAge(Person person)
        {
            person.Birthday = DateTime.Now;
            return person.Age;
        }

        public static Person GetPersonWith20YearsOld()
        {
            return new Person
            {
                Birthday = new DateTime(1999, 3, 16)
            };
        }

        public void SetPersonWith20YearsOld()
        {
            this.Birthday = new DateTime(1999, 3, 16);
        }

    }
}
