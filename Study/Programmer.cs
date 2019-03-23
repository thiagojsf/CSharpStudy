using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Programmer : Person, ILikeTo
    {

        public const string I_LIKE = "Create programs";

        public List<Language> Languages;

        public Programmer()
        {
            Languages = new List<Language>();
        }

        public string LikesTo()
        {
            return I_LIKE;
        }

        public virtual string GetPreferedIDE()
        {
            return "Notepad";
        }

        public static void GetAttribute(Type t)
        {
            // Get instance of the attribute.
            DatabaseDeveloperAttribute MyAttribute =
                (DatabaseDeveloperAttribute)Attribute.GetCustomAttribute(t, typeof(DatabaseDeveloperAttribute));

            if (MyAttribute == null)
            {
                Console.WriteLine("The attribute was not found.");
            }
            else
            {
                string query = MyAttribute.GetQueryForTenFirstRecords();
                Console.WriteLine("Query for get the 10 first records:" + query);
            }
        }

    }
}
