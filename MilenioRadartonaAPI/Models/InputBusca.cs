using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MilenioRadartonaAPI.Models
{
    public class InputBusca
    {
        public InputBusca()
        {
        }


        public DateTime Dia { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Raio { get; set; }
        public string Evento { get; set; }
        public DateTime DtInicio { get; set; }
        public string DtFim { get; set; }
        public string LatInicio { get; set; }
        public string LatFim { get; set; }
        public string LonFim { get; set; }
        public string LonInicio { get; set; }
        public string Anormalidade { get; set; }
        


    }
}
