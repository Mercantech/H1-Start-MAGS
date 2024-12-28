using Xunit;
using Opgaver;
using System;
using System.IO;
using System.Linq;

namespace StartTester.Dag4og5Tests;
[Collection("Sequential")]
public class DebugOpgaveTests
{
    [Fact]
    
    public void DebugOpgave_SkalUdskriveTalArrayKorrekt()
    {
        // Arrange
        var dag4og5 = new Dag4og5();
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act
        dag4og5.DebugOpgave();
        var output = stringWriter.ToString();
        var lines = output.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        var talLines = lines.Skip(1).Take(5); // Skip overskriften, tag de første 5 tal

        // Assert
        Assert.Equal("1", talLines.ElementAt(0));
        Assert.Equal("2", talLines.ElementAt(1));
        Assert.Equal("3", talLines.ElementAt(2));
        Assert.Equal("4", talLines.ElementAt(3));
        Assert.Equal("5", talLines.ElementAt(4));
    }

    [Fact]

    public void DebugOpgave_SkalUdskriveDivisionerKorrekt()
    {
        // Arrange
        var dag4og5 = new Dag4og5();
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act
        dag4og5.DebugOpgave();
        var output = stringWriter.ToString();
        var lines = output.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        var divisionLines = lines.Skip(6).Take(5); // Skip overskrift og array tal, tag divisions resultater

        // Assert
        Assert.Equal("2", divisionLines.ElementAt(0));  // 10/5
        Assert.Equal("2", divisionLines.ElementAt(1));  // 10/4
        Assert.Equal("3", divisionLines.ElementAt(2));  // 10/3
        Assert.Equal("5", divisionLines.ElementAt(3));  // 10/2
        Assert.Equal("10", divisionLines.ElementAt(4)); // 10/1
    }

    [Fact]
    public void DebugOpgave_SkalHaveKorrektOverskrift()
    {
        // Arrange
        var dag4og5 = new Dag4og5();
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act
        dag4og5.DebugOpgave();
        var output = stringWriter.ToString();

        // Assert
        Assert.Contains("=== Opgave 3: Debug Denne Kode ===", output);
    }

    [Fact]
    public void DebugOpgave_SkalIkkeKasteDivideByZeroException()
    {
        // Arrange
        var dag4og5 = new Dag4og5();
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act & Assert
        var exception = Record.Exception(() => dag4og5.DebugOpgave());
        Assert.Null(exception); // Ingen exception skulle blive kastet
    }

    [Fact]
    public void DebugOpgave_SkalIkkeKasteIndexOutOfRangeException()
    {
        // Arrange
        var dag4og5 = new Dag4og5();
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act & Assert
        var exception = Record.Exception(() => dag4og5.DebugOpgave());
        Assert.Null(exception); // Ingen exception skulle blive kastet
    }
}