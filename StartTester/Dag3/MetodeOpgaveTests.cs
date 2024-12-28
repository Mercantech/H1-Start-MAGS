using Xunit;
using Opgaver;
using System;
using System.Threading.Tasks;

namespace OpgaverTests.Dag3Tests
{
    [Collection("Sequential")]
    public class BeregnGennemsnitTests
    {
        private readonly Dag3 _dag3;

        public BeregnGennemsnitTests()
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
    }

    [Collection("Sequential")]
    public class FindStørsteTalTests
    {
        private readonly Dag3 _dag3;

        public FindStørsteTalTests()
        {
            _dag3 = new Dag3();
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
    }

    [Collection("Sequential")]
    public class TælForekomsterTests
    {
        private readonly Dag3 _dag3;

        public TælForekomsterTests()
        {
            _dag3 = new Dag3();
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