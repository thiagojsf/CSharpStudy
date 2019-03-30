using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportTest
{
    [Table("Airport")]
    public class Airport
    {
        [Key]
        public int AirportId { get; set; }
        public decimal CityId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Disabled { get; set; }
    }
}
