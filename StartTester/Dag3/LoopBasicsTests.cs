using Xunit;
using Opgaver;
using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Threading.Tasks;

namespace OpgaverTests.Dag3Tests
{
    public class LoopBasicsTests
    {
        private readonly Dag3 _dag3;

        public LoopBasicsTests()
        {
            _dag3 = new Dag3();
        }

        [Fact]
        public void UdskrivTalRække_SkalUdskriveTal1Til10()
        {
            // Arrange
            var output = new StringWriter();

            // Act
            var task = Task.Run(() =>
            {
                Console.SetOut(output);
                _dag3.UdskrivTalRække();
            });

            // Sæt en timeout på 5 sekunder
            var completed = task.Wait(5000);
            Assert.True(completed, "Metoden tog for lang tid");

            string result = output.ToString();
            var numbers = result.Split('\n')
                              .Select(line => line.Trim())
                              .Where(line => Regex.IsMatch(line, @"^([1-9]|10)$"))
                              .Select(int.Parse)
                              .ToList();

            // Assert
            Assert.Equal(10, numbers.Count);
            Assert.Equal(Enumerable.Range(1, 10), numbers);
        }


        [Fact]
        public void GættespilMedWhileLoop_SkalStoppeEfter10Forsøg()
        {
            // Arrange
            var output = new StringWriter();
            var input = new StringReader(string.Join("\n", Enumerable.Repeat("1", 11))); // 11 gæt for at være sikker

            // Act
            var task = Task.Run(() =>
            {
                Console.SetOut(output);
                Console.SetIn(input);
                _dag3.GættespilMedWhileLoop();
            });

            // Sæt en timeout på 5 sekunder
            var completed = task.Wait(5000);
            Assert.True(completed, "Metoden tog for lang tid");

            string result = output.ToString().ToLower();

            // Assert
            Assert.Contains("10 forsøg", result);
        }

    }
} 