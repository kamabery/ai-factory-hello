namespace Hello.Tests;

public class GreetingTests
{
    [Fact]
    public void Greets_the_world() => Assert.Equal("Hello, world!", Greeting.Text());
}
