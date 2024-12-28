using Xunit;
using Opgaver;
using System;
using System.Threading.Tasks;

namespace OpgaverTests.Dag3Tests
{
    public class MetodeOpgaveTests
    {
        private readonly Dag3 _dag3;

        public MetodeOpgaveTests()
        {
            _dag3 = new Dag3();
        }

        [Fact]
        public void BeregnGennemsnit_SkalReturnereKorrektGennemsnit()
        {
            // Arrange
            var output = new StringWriter();

            // Act
            var task = Task.Run(() =>
            {
                Console.SetOut(output);
                _dag3.MetodeOpgave();
            });
            task.Wait();

            string result = output.ToString();

            // Assert
            Assert.Contains("Gennemsnit: ", result);
            Assert.DoesNotContain("Gennemsnit: 0", result);
        }

        [Fact]
        public void FindStørsteTal_SkalReturnereKorrektTal()
        {
            // Arrange
            var output = new StringWriter();

            // Act
            var task = Task.Run(() =>
            {
                Console.SetOut(output);
                _dag3.MetodeOpgave();
            });
            task.Wait();

            string result = output.ToString();

            // Assert
            Assert.Contains("Største tal: 1000", result);
        }

        [Fact]
        public void TælForekomster_SkalReturnereKorrektAntal()
        {
            // Arrange
            var output = new StringWriter();

            // Act
            var task = Task.Run(() =>
            {
                Console.SetOut(output);
                _dag3.MetodeOpgave();
            });
            task.Wait();

            string result = output.ToString();

            // Assert
            Assert.Contains("Antal 8-taller: 3", result);
        }
    }
} 