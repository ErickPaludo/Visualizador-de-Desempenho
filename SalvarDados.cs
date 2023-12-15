using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ViewDesemp
{

    public class SalvarDados
    {
        static string arquivo = "Logs.txt";
        static List<Relatorio> relat = new List<Relatorio>();

        Monitor monitor = new Monitor();


        public SalvarDados()
        {
        }

        public void GravarDados()
        {
            StreamWriter sw = File.CreateText(arquivo);
            relat.Add(new Relatorio(monitor.CPU(),monitor.RAMPORCENTAGEM(),DateTime.Now));
            foreach(Relatorio relatorio in relat)
            {
                sw.WriteLine(relatorio.ToString());
            }
            sw.Close();
        }
    }
}
