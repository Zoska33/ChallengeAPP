using NUnit.Framework.Internal;
using System.Reflection.Metadata;

namespace ChallengeApp.tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectThreeScores_ShouldPositiveResult()
        {
            // arrange
            var employee = new Employee("Daniel", "Kozlowski", 30);
            employee.AddScore(5);
            employee.AddScore(8);
            employee.AddScore(-5);

            //act 
            var result = employee.Result;

            //assert
            Assert.AreEqual(8, result);
        }
        [Test]
        public void WennEmployeeCollectThreeScores_ShouldZeroResult()
        {
            //arrage 
            var employee = new Employee("Marian", "Kruk", 18);
            employee.AddScore(3);
            employee.AddScore(0);
            employee.AddScore(-3);

            //act
            var result = employee.Result;

            //assert
           Assert.AreEqual(0, result);
        }
        [Test]
        public void WennEmployeeCollectThreeScores_ShouldNegativeResult()
        {
            //arrage
            var employee = new Employee("Balbina", "Kaczka", 59);
            employee.AddScore(7);
            employee.AddScore(-3);
            employee.AddScore(-5);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(-1, result);
        }

     }
}