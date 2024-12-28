using Xunit;
using Opgaver;
using System;
using System.IO;
namespace StartTester.Dag4og5Tests;
[Collection("Sequential")]
public class SkakbraetOpgaveTests
{
    [Fact]
    public void SkakbraetOpgave_SkalUdskriveKorrektMoenstrer()
    {
        // Arrange
        var dag4og5 = new Dag4og5();
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act
        dag4og5.SkakbraetOpgave();
        var output = stringWriter.ToString();

        // Assert
        // Tjek at outputtet indeholder både hvide og sorte felter
        Assert.Contains("🔳", output);
        Assert.Contains("🔲", output);

        // Tjek at der er 8 linjer (8x8 bræt)
        var lines = output.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        var skakLines = lines.Skip(1).Take(8); // Skip overskriften
        Assert.Equal(8, skakLines.Count());

        // Tjek at hver linje har 8 felter
        foreach (var line in skakLines)
        {
            Assert.Equal(8, line.Length / 2); // Deler med 2 da hver emoji tæller som 2 karakterer
        }

        // Tjek at mønstret alternerer korrekt
        var firstLine = skakLines.First();
        Assert.Equal("🔳🔲🔳🔲🔳🔲🔳🔲", firstLine);
        
        var secondLine = skakLines.Skip(1).First();
        Assert.Equal("🔲🔳🔲🔳🔲🔳🔲🔳", secondLine);
    }

    [Fact]
    public void SkakbraetOpgave_SkalHaveKorrektOverskrift()
    {
        // Arrange
        var dag4og5 = new Dag4og5();
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act
        dag4og5.SkakbraetOpgave();
        var output = stringWriter.ToString();

        // Assert
        Assert.Contains("=== Opgave 1: Skakbræt ===", output);
    }
} 