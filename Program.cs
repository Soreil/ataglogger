using System.Text.Json;

CancellationTokenSource Cts = new();

string? ReadFromThermostat()
{
    string output = "";

    try
    {
        using (var myProc = new System.Diagnostics.Process())
        {
            myProc.StartInfo.UseShellExecute = false;
            myProc.StartInfo.FileName = "java";
            myProc.StartInfo.Arguments = "-jar atag-one.jar";
            myProc.StartInfo.CreateNoWindow = true;
            myProc.StartInfo.RedirectStandardOutput = true;
            myProc.Start();

            var reader = myProc.StandardOutput;
            output = reader.ReadToEnd();
            myProc.WaitForExit();
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        return null;
    }
    return output;
}

Task cb()
{
    var output = ReadFromThermostat();
    if (output is null or "")
    {
        return Task.CompletedTask;
    }

    var state = JsonSerializer.Deserialize<ThermostatState>(output);
    if (state is null)
    {
        throw new Exception("Malformed JSON");
    }

    using (var db = new ThermostatDbContext())
    {
        db.Add(state);
        db.SaveChanges();
    }

    return Task.CompletedTask;
}

var timer = new System.Timers.Timer(60000);
timer.Elapsed += async (sender, e) => await cb();

timer.Start();

await Task.Delay(Timeout.Infinite, Cts.Token).ConfigureAwait(false);