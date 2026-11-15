namespace Hello;

/// <summary>Turns the command-line arguments into the line the app prints.</summary>
public static class GreeterArgs
{
    public static string Run(IReadOnlyList<string> args)
    {
        string? name = null;
        for (var i = 0; i < args.Count; i++)
        {
            if (args[i] == "--name" && i + 1 < args.Count)
            {
                name = args[++i];
            }
        }

        return Greeting.Text(name);
    }
}
