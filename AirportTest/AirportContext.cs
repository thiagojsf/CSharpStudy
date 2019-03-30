using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportTest
{
    public class AirportContext : DbContext
    {
        public AirportContext(string connectionString) : base(connectionString)
        {

        }

        public DbSet<Airport> Airports { get; set; }
    }
}
