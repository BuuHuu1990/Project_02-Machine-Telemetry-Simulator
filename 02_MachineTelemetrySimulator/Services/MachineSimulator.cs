using _02_MachineTelemetrySimulator.Models;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace _02_MachineTelemetrySimulator.Services
{
    public class MachineSimulator
    {
        private string MachineName;
        TelementryPrinter TelementryPrinter = new();
        private readonly Random _random = new Random();
 
   
        public MachineSimulator(string machineName)
        {
            MachineName = machineName;
        }

        public async Task RunAsync()
        {
            for (int i = 0; i <= 5; i++)
            {
                TelemetryData telemetryData = new(MachineName, DateTime.UtcNow, GetTemp(), true);
                TelementryPrinter.Print(telemetryData);
                await Task.Delay(1000);
            }
        }

        public double GetTemp()
        {
            var temp = _random.NextDouble() * 100;
            return temp;
        }
    }
}
