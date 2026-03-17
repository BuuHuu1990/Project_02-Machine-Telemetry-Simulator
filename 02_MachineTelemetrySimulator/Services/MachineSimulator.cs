using _02_MachineTelemetrySimulator.Models;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace _02_MachineTelemetrySimulator.Services
{
    public class MachineSimulator
    {
        private string _machineName;
        TelementryPrinter _telementryPrinter = new();
        private readonly Random _random = new Random();
 

        public MachineSimulator(string machineName)
        {
            _machineName = machineName;
        }


        public async Task RunAsync(CancellationToken token)
        {
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine($"{_machineName} stopping...");
                        break;
                    }

                    TelemetryData telemetryData = new(_machineName, DateTime.UtcNow, GetTemp(), true);

                    _telementryPrinter.Print(telemetryData);

                    await Task.Delay(1000, token);
                }
            }
            catch (TaskCanceledException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public double GetTemp()
        {
            var temp = _random.NextDouble() * 100;
            return temp;
        }
    }
}
