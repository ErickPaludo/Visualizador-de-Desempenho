using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewDesemp
{
    public class Relatorio
    {
        public string InfoCPU { get; set; }
        public string InfoRAM { get; set; }
        public DateTime DataHora { get; set; }

        public Relatorio(string infoCPU, string infoRAM, DateTime dataHora)
        {
            InfoCPU = infoCPU;
            InfoRAM = infoRAM;
            DataHora = dataHora;
        }
        public override string ToString()
        {
            return $"CPU: {InfoCPU}% / RAM: {InfoRAM}% / DATE: {DataHora} ";
        }
    }
}
