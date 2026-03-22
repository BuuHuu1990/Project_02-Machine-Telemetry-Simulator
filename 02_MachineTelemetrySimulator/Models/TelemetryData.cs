using System;
using System.Collections.Generic;
using System.Text;

namespace _02_MachineTelemetrySimulator.Models
{
    public class TelemetryData
    {
        public string MachineName { get; }
        public DateTime Timestamp {  get; }
        public double Temperature { get;  }
        public bool IsRunning { get;  }

        public TelemetryData(string machineName, DateTime timestamp, double temperature, bool isRunning)
        {
            MachineName = machineName;
            Timestamp = timestamp;
            Temperature = temperature;
            IsRunning = isRunning;
        }
    }
}
