using System;
using System.Collections.Generic;
using System.Text;

namespace Automotivo
{
    public class Tapete
    {
        public int TapeteId { get; set; }
        public bool IndicaTapeteBorracha { get; set; }
        public string Cor { get; set; }
        public List<Log> Logs { get; set; }
    }
}
