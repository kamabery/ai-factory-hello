namespace Hello;

/// <summary>Turns the command-line arguments into the text the app prints.</summary>
public static class GreeterArgs
{
    public static string Run(IReadOnlyList<string> args)
    {
        string? name = null;
        var shout = false;
        var times = 1;
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
            else if (args[i] == "--times")
            {
                // A following flag (e.g. "--shout") is not a value: leave it for the loop.
                if (i + 1 < args.Count && !args[i + 1].StartsWith("--", StringComparison.Ordinal))
                {
                    times = ParseTimes(args[++i]);
                }
            }
        }

        var line = Greeting.Text(name);
        if (shout)
        {
            line = line.ToUpperInvariant();
        }

        return string.Join(Environment.NewLine, Enumerable.Repeat(line, times));
    }

    /// <summary>A positive whole number, or 1 for anything else (zero, negative, non-number, overflow).</summary>
    private static int ParseTimes(string value) =>
        int.TryParse(value, System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture, out var n) && n > 0
            ? n
            : 1;
}
