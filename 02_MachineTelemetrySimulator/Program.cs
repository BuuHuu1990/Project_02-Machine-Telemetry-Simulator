using _02_MachineTelemetrySimulator.Services;
using System;

internal class Program
{
    private static async Task Main(string[] args)
    {
        MachineSimulator machine1 = new("01_Mixer");
        MachineSimulator machine2 = new("02_Trockner");
        MachineSimulator machine3 = new("03_Blaskammer");

        await Task.WhenAll(machine1.RunAsync(), machine2.RunAsync(), machine3.RunAsync());
    }
}