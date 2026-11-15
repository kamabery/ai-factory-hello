namespace Hello.Tests;

public class GreetingTests
{
    [Fact]
    public void Greets_the_world() => Assert.Equal("Hello, world!", Greeting.Text());

    [Fact]
    public void Greets_a_name() => Assert.Equal("Hello, Ada!", Greeting.Text("Ada"));

    [Fact]
    public void Null_name_greets_the_world() => Assert.Equal("Hello, world!", Greeting.Text(null));

    [Fact]
    public void Blank_name_greets_the_world() => Assert.Equal("Hello, world!", Greeting.Text("  "));
}
