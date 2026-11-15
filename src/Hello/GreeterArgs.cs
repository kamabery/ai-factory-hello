namespace Hello;

/// <summary>Turns the command-line arguments into the line the app prints.</summary>
public static class GreeterArgs
{
    public static string Run(IReadOnlyList<string> args)
    {
        string? name = null;
        var shout = false;
        for (var i = 0; i < args.Count; i++)
        {
            if (args[i] == "--name" && i + 1 < args.Count)
            {
                name = args[++i];
            }
            else if (args[i] == "--shout")
            {
                shout = true;
            }
        }

        var line = Greeting.Text(name);
        return shout ? line.ToUpperInvariant() : line;
    }
}
