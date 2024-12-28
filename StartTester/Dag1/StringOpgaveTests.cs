using Xunit;
using Opgaver;
using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;

namespace OpgaverTests.Dag1Tests
{   
[Collection("Sequential")]
public class StringOpgaveTests
{
    private readonly Dag1 _dag1;

    public StringOpgaveTests()
    {
        _dag1 = new Dag1();
    }

    [Theory]
    [InlineData("test", "TEST", 4)]
    [InlineData("Peter", "PETER", 5)]
    [InlineData("Anna-Marie", "ANNA-MARIE", 10)]
    public void StringOpgave_SkalKonvertereOgTælleKorrekt(string input, string forventetOutput, int forventetLængde)
    {
        // Arrange
        var consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);
        Console.SetIn(new StringReader(input));

        // Act
        _dag1.StringOpgave();
        string output = consoleOutput.ToString();

        // Assert
        Assert.Contains(forventetOutput, output);
            Assert.Contains(forventetLængde.ToString(), output);
            }
    } 
}