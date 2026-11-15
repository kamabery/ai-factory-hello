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
}
