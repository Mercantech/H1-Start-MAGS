using Xunit;
using Opgaver;
using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;

namespace OpgaverTests.Dag1Tests
{
[Collection("Sequential")]
public class PasswordGeneratorTests
{
    private readonly Dag1 _dag1;

    public PasswordGeneratorTests()
    {
        _dag1 = new Dag1();
    }

    [Fact]
    public void PasswordGenerator_SkalGenererGyldigtPassword()
    {
        // Arrange
        var consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);
        Console.SetIn(new StringReader("12")); // Antager at vi beder om et 12-tegn password

        // Act
        _dag1.PasswordGenerator();
        string output = consoleOutput.ToString();

        // Find password i output ved at lede efter linjen med det genererede password
        var passwordLine = output.Split('\n')
            .FirstOrDefault(line => line.Contains("Dit genererede password er:"));
        
        if (passwordLine != null)
        {
            string password = passwordLine.Split(':')[1].Trim();

            // Assert
            Assert.True(password.Length >= 8);
            Assert.Matches(@"[A-Z]", password);
            Assert.Matches(@"[a-z]", password);
            Assert.Matches(@"[0-9]", password);
            Assert.Matches(@"[!@#$%^&*()]", password);
        }
        else
        {
                Assert.True(false, "Kunne ikke finde det genererede password i output");
            }
        }
        }
} 