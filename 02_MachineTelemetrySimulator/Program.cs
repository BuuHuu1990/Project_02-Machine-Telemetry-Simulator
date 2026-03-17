using _02_MachineTelemetrySimulator.Services;
using System;

internal class Program
{
    private static async Task Main(string[] args)
    {
        MachineSimulator machine1 = new("01_Mixer");
        MachineSimulator machine2 = new("02_Trockner");
        MachineSimulator machine3 = new("03_Blaskammer");

        var cts = new CancellationTokenSource();
        CancellationToken token = cts.Token;

        Task t1 = machine1.RunAsync(token);
        Task t2 = machine2.RunAsync(token);
        Task t3 = machine3.RunAsync(token);   

        Console.WriteLine("Press any key to stop simulation...");
        Console.ReadKey();
        cts.Cancel();

        await Task.WhenAll(t1, t2, t3);
        Console.WriteLine("Simulation stopped.");
    }
}