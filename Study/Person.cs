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
        public int Age
        {
            get
            {
                int age = DateTime.Today.Year - Birthday.Year;

                if (Birthday > DateTime.Today.AddYears(-age))
                    age--;

                return age;
            }
        }
        #endregion
    }
}
