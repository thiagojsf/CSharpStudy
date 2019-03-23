using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class DatabaseDeveloperAttribute : Attribute
    {
        public enum MostlyUserDatabases
        {
            Oracle,
            MSSQLServer,
            MySQL,
            Postgree
        }

        private MostlyUserDatabases Database;

        public DatabaseDeveloperAttribute(MostlyUserDatabases database)
        {
            this.Database = database;
        }

        public string GetQueryForTenFirstRecords()
        {
            switch (this.Database)
            {
                case MostlyUserDatabases.MSSQLServer:
                    return "SELECT TOP 10 * FROM TABLE";
                case MostlyUserDatabases.Oracle:
                    return "SELECT * FROM TABLE WHERE ROWNUM <= 10";
                default:
                    return "SELECT * FROM TABLE LIMIT 10";
            }

        }
    }
}
