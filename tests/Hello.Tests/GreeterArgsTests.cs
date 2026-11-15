namespace Hello.Tests;

public class GreeterArgsTests
{
    [Fact]
    public void Name_argument_greets_that_name() =>
        Assert.Equal("Hello, Ada!", GreeterArgs.Run(["--name", "Ada"]));

    [Fact]
    public void No_arguments_greets_the_world() =>
        Assert.Equal("Hello, world!", GreeterArgs.Run([]));

    [Fact]
    public void Name_flag_without_value_greets_the_world() =>
        Assert.Equal("Hello, world!", GreeterArgs.Run(["--name"]));

    [Fact]
    public void Shout_without_name_shouts_at_the_world() =>
        Assert.Equal("HELLO, WORLD!", GreeterArgs.Run(["--shout"]));

    [Fact]
    public void Shout_after_name_shouts_the_whole_line() =>
        Assert.Equal("HELLO, ADA!", GreeterArgs.Run(["--name", "Ada", "--shout"]));

    [Fact]
    public void Shout_before_name_shouts_the_whole_line() =>
        Assert.Equal("HELLO, ADA!", GreeterArgs.Run(["--shout", "--name", "Ada"]));

    private static string[] Lines(string output) =>
        output.Split(["\r\n", "\n"], StringSplitOptions.None);

    [Fact]
    public void Times_three_greets_three_times()
    {
        var lines = Lines(GreeterArgs.Run(["--times", "3"]));
        Assert.Equal(3, lines.Length);
        Assert.All(lines, line => Assert.Equal("Hello, world!", line));
    }

    [Theory]
    [InlineData("0")]
    [InlineData("-2")]
    public void Times_zero_or_negative_greets_once(string value)
    {
        var lines = Lines(GreeterArgs.Run(["--times", value]));
        Assert.Equal(["Hello, world!"], lines);
    }

    [Theory]
    [InlineData("abc")]
    [InlineData("99999999999")]
    public void Times_non_number_greets_once(string value)
    {
        var lines = Lines(GreeterArgs.Run(["--times", value]));
        Assert.Equal(["Hello, world!"], lines);
    }

    [Fact]
    public void Times_without_value_greets_once()
    {
        var lines = Lines(GreeterArgs.Run(["--times"]));
        Assert.Equal(["Hello, world!"], lines);
    }

    [Fact]
    public void Times_followed_by_shout_does_not_swallow_shout()
    {
        var lines = Lines(GreeterArgs.Run(["--times", "--shout"]));
        Assert.Equal(["HELLO, WORLD!"], lines);
    }

    [Fact]
    public void Name_shout_times_greets_shouting_three_times()
    {
        var lines = Lines(GreeterArgs.Run(["--name", "Ada", "--shout", "--times", "3"]));
        Assert.Equal(3, lines.Length);
        Assert.All(lines, line => Assert.Equal("HELLO, ADA!", line));
    }

    [Fact]
    public void Times_shout_name_greets_shouting_three_times()
    {
        var lines = Lines(GreeterArgs.Run(["--times", "3", "--shout", "--name", "Ada"]));
        Assert.Equal(3, lines.Length);
        Assert.All(lines, line => Assert.Equal("HELLO, ADA!", line));
    }
}
