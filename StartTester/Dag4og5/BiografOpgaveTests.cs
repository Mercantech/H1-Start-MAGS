using Xunit;
using Opgaver;
using System;
using System.IO;
namespace StartTester.Dag4og5Tests;

[Collection("Sequential")]
public class BiografOpgaveTests
{
    [Fact]
    public void BiografOpgave_SkalKunneBookeSaede()
    {
        // Arrange
        var dag4og5 = new Dag4og5();
        var stringWriter = new StringWriter();
        var stringReader = new StringReader("2\n3\n-1\n"); // Simulerer input: række 2, sæde 3, afslut
        Console.SetOut(stringWriter);
        Console.SetIn(stringReader);

        // Act
        dag4og5.BiografOpgave();
        var output = stringWriter.ToString();

        // Assert
        Assert.Contains("Sæde booket!", output);
    }

    [Fact]
    public void BiografOpgave_SkalIkkeKunneBookeOptagetSaede()
    {
        // Arrange
        var dag4og5 = new Dag4og5();
        var stringWriter = new StringWriter();
        var stringReader = new StringReader("2\n3\n2\n3\n-1\n"); // Forsøger at booke samme sæde to gange
        Console.SetOut(stringWriter);
        Console.SetIn(stringReader);

        // Act
        dag4og5.BiografOpgave();
        var output = stringWriter.ToString();

        // Assert
        Assert.Contains("Sædet er allerede optaget!", output);
    }

    [Fact]
    public void BiografOpgave_SkalHaandtereUgyldigtInput()
    {
        // Arrange
        var dag4og5 = new Dag4og5();
        var stringWriter = new StringWriter();
        var stringReader = new StringReader("8\n3\n-1\n"); // Ugyldig række (8 er uden for 0-6)
        Console.SetOut(stringWriter);
        Console.SetIn(stringReader);

        // Act
        dag4og5.BiografOpgave();
        var output = stringWriter.ToString();

        // Assert
        Assert.Contains("Ugyldigt valg!", output);
    }

    [Fact]
    public void BiografOpgave_SkalViseKorrektSalLayout()
    {
        // Arrange
        var dag4og5 = new Dag4og5();
        var stringWriter = new StringWriter();
        var stringReader = new StringReader("-1\n"); // Afslut med det samme
        Console.SetOut(stringWriter);
        Console.SetIn(stringReader);

        // Act
        dag4og5.BiografOpgave();
        var output = stringWriter.ToString();

        // Assert
        var lines = output.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        // Find kun de linjer der indeholder sæder (O'er og X'er)
        var salLines = lines.Where(l => l.Trim().StartsWith("O") || l.Trim().StartsWith("X")).ToList();
        
        // Tjek at salen har 7 rækker
        Assert.Equal(7, salLines.Count);
        
        // Tjek at hver række har 12 sæder
        foreach (var line in salLines)
        {
            var seats = line.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Assert.Equal(12, seats.Length);
        }
    }

    [Fact]
    public void BiografOpgave_SkalHaveKorrektOverskrift()
    {
        // Arrange
        var dag4og5 = new Dag4og5();
        var stringWriter = new StringWriter();
        var stringReader = new StringReader("-1\n");
        Console.SetOut(stringWriter);
        Console.SetIn(stringReader);

        // Act
        dag4og5.BiografOpgave();
        var output = stringWriter.ToString();

        // Assert
        Assert.Contains("=== Opgave 2: Biograf Booking ===", output);
    }
} 