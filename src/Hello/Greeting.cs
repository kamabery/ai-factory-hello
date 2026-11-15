namespace Hello;

/// <summary>What the app says.</summary>
public static class Greeting
{
    /// <summary>Greets <paramref name="name"/>, or the world when it is null or blank.</summary>
    public static string Text(string? name = null) =>
        string.IsNullOrWhiteSpace(name) ? "Hello, world!" : $"Hello, {name.Trim()}!";
}
