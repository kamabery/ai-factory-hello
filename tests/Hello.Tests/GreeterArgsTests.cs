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
}
