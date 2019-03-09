using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Employee : Person
    {

        public class UnderAgeException : Exception
        {

        }

        public Employee(DateTime birthday)
        {
            this.Birthday = birthday;

            if (Age < 18)
                throw new UnderAgeException();
        }

    }
}
