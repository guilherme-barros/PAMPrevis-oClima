using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimaTempo.Models
{
    public class Clima
    {
        public DateOnly Data { get; set; }
        public string Condicao { get; set; }
        public string Condicao_desc { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public double Indice_uv { get; set; }
    }
}
