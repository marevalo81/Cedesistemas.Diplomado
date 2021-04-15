using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiRest.Models
{
    public class Pais
    {
        public string iso3 { get; set; }
        public string nombre { get; set; }
        public bool isValid { get; set; }
        public string gobierno { get; set; }
    }
}
