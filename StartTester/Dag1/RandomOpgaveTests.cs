using Xunit;
using Opgaver;
using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;


namespace OpgaverTests.Dag1Tests
{
[Collection("Sequential")]
public class RandomOpgaveTests
{
    private readonly Dag1 _dag1;

    public RandomOpgaveTests()
    {
        _dag1 = new Dag1();
    }

    [Fact]
    public void RandomOpgave_SkalGenerereFemTalMellem1Og100()
    {
        // Arrange
        var consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);

        // Act
        _dag1.RandomOpgave();
        string output = consoleOutput.ToString();

        // Udtræk kun tal efter "Tal X: " mønsteret
        var numbers = Regex.Matches(output, @"Tal \d+: (\d+)")
                          .Cast<Match>()
                          .Select(m => int.Parse(m.Groups[1].Value))
                          .ToList();

        // Assert
        Assert.Equal(5, numbers.Count);
            Assert.All(numbers, num => Assert.InRange(num, 1, 100));
        }
    } 
}