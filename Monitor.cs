using System;
using System.Diagnostics;
using NickStrupat;
using System.Collections.Generic;
using OpenHardwareMonitor.Hardware;
using ViewDesemp;
using System.Threading;

namespace ViewDesemp
{

    public class Monitor
    {
        ComputerInfo pc = new ComputerInfo();
        PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total"); //Exibe o usto total da CPU
        PerformanceCounter memoryCounter = new PerformanceCounter("Memory", "Available MBytes");

        public Monitor()
        {
        }
        public string CPU()
        {
            return $"{Convert.ToInt64(cpuCounter.NextValue())}";
        }
        public string RAMPORCENTAGEM()
        {
            ulong rambyte = pc.TotalPhysicalMemory; //salva a quantidade de ram que o pc possui
            double rammb = rambyte / Math.Pow(10, 6);
            var total = rammb - memoryCounter.NextValue();
            var porcentagemram = (total / rammb) * 100;
            return $"{porcentagemram.ToString("0")}";
        }
        public string RAMTOTAL()
        {
            ulong rambyte = pc.TotalPhysicalMemory; //salva a quantidade de ram que o pc possui
            double rammb = rambyte / Math.Pow(10, 6);
            var total = rammb - memoryCounter.NextValue();
            var porcentagemram = (total / rammb) * 100;
            return $"{rammb.ToString("0")}";
        }
        public string RAMUSADA()
        {
            ulong rambyte = pc.TotalPhysicalMemory; //salva a quantidade de ram que o pc possui
            double rammb = rambyte / Math.Pow(10, 6);
            var total = rammb - memoryCounter.NextValue();
            var porcentagemram = (total / rammb) * 100;
            return $"{total.ToString("0")}";
        }
    }
}

