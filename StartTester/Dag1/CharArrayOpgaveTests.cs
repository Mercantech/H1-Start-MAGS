using Xunit;
using Opgaver;
using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;

namespace OpgaverTests.Dag1Tests
{
[Collection("Sequential")]
public class CharArrayOpgaveTests
{
    private readonly Dag1 _dag1;

    public CharArrayOpgaveTests()
    {
        _dag1 = new Dag1();
    }

    [Theory]
    [InlineData(65, 'A')]
    [InlineData(90, 'Z')]
    [InlineData(77, 'M')]
    public void CharArrayOpgave_SkalHåndtereASCIIKorrekt(int asciiVærdi, char forventetBogstav)
    {
        // Arrange
        var consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);
        Console.SetIn(new StringReader(asciiVærdi.ToString()));

        // Act
        _dag1.CharArrayOpgave();
        string output = consoleOutput.ToString();

        // Assert
        Assert.Contains(asciiVærdi.ToString(), output);
            Assert.Contains(forventetBogstav.ToString(), output);
        }
    } 
}