using _02_MachineTelemetrySimulator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02_MachineTelemetrySimulator.Services
{
    public class TelementryPrinter
    {
        public void Print(TelemetryData data)
        {
            string status = data.IsRunning ? "Running" : "Stopped";

            Console.WriteLine($"[{data.Timestamp:HH:mm:ss}] {data.MachineName} | Temp: {data.Temperature:F1}°C | {status}");
        }
    }
}
