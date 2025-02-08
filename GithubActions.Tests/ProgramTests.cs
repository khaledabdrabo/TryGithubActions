using Xunit;

namespace GithubActions.Tests;

public class ProgramTests
{
    [Fact]
    public void GetMessage_ShouldReturnHelloWorld()
    {
        // Arrange & Act
        string result = Program.GetMessage();

        // Assert
        Assert.Equal("Hello, World!", result);
    }
} 