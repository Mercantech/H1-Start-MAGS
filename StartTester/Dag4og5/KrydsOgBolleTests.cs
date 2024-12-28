using Xunit;
using Opgaver;
using System;
using System.IO;

namespace StartTester.Dag4og5Tests;
[Collection("Sequential")]
public class KrydsOgBolleTests
{
    
    [Fact]
    public void KrydsOgBolle_SkalOpdageVandretVinder()
    {
        // Arrange
        var dag4og5 = new Dag4og5();
        var stringWriter = new StringWriter();
        // X spiller: (0,0), (0,1), (0,2) - vandret række
        var stringReader = new StringReader("0\n0\n1\n1\n0\n1\n1\n2\n0\n2\n");
        Console.SetOut(stringWriter);
        Console.SetIn(stringReader);

        // Act
        dag4og5.KrydsOgBolle();
        var output = stringWriter.ToString();

        // Assert
        Assert.Contains("Spiller X har vundet!", output);
    }

    [Fact]
    public void KrydsOgBolle_SkalOpdageLodretVinder()
    {
        // Arrange
        var dag4og5 = new Dag4og5();
        var stringWriter = new StringWriter();
        // X spiller: (0,0), (1,0), (2,0) - lodret række
        var stringReader = new StringReader("0\n0\n0\n1\n1\n0\n0\n2\n2\n0\n");
        Console.SetOut(stringWriter);
        Console.SetIn(stringReader);

        // Act
        dag4og5.KrydsOgBolle();
        var output = stringWriter.ToString();

        // Assert
        Assert.Contains("Spiller X har vundet!", output);
    }

    [Fact]
    public void KrydsOgBolle_SkalOpdageDiagonalVinder()
    {
        // Arrange
        var dag4og5 = new Dag4og5();
        var stringWriter = new StringWriter();
        // X spiller: (0,0), (1,1), (2,2) - diagonal
        var stringReader = new StringReader("0\n0\n0\n1\n1\n1\n0\n2\n2\n2\n");
        Console.SetOut(stringWriter);
        Console.SetIn(stringReader);

        // Act
        dag4og5.KrydsOgBolle();
        var output = stringWriter.ToString();

        // Assert
        Assert.Contains("Spiller X har vundet!", output);
    }

    [Fact]
    public void KrydsOgBolle_SkalOpdageUafgjort()
    {
        // Arrange
        var dag4og5 = new Dag4og5();
        var stringWriter = new StringWriter();
        // Spil der ender uafgjort
        var stringReader = new StringReader("0\n0\n0\n1\n0\n2\n1\n1\n1\n0\n2\n0\n1\n2\n2\n2\n2\n1\n");
        Console.SetOut(stringWriter);
        Console.SetIn(stringReader);

        // Act
        dag4og5.KrydsOgBolle();
        var output = stringWriter.ToString();

        // Assert
        Assert.Contains("Uafgjort!", output);
    }

    

    
} 