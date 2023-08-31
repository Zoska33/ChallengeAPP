namespace ChallengeApp.tests
{
    public class TypeTests
    {
        [Test]
        public void TestIntResult()
        {
            // arrange
            int number1 = 85;
            int number2 = 85;

            //act 
            //assert
            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void TestFloatResult()
        {
            // arrange
            float flt1 = 846922556;
            float flt2 = 852110035;

            //act 
            //assert
            Assert.AreNotEqual(flt1, flt2);
        }
        [Test]
        public void TestCharResult()
        {
            // arrange
            char letter1 = 'x';
            char letter2 = 'x';

            //act 
            //assert
            Assert.AreEqual(letter1, letter2);
        }
        [Test]
        public void TestBoolResult()
        {
            // arrange
            bool bl1 = true;
            bool bl2 = false;

            //act 
            //assert
            Assert.AreNotEqual(bl1, bl2);
        }
        [Test]
        public void TestStringResult()
        {
            // arrange
            string str1 = "Kaczka";
            string str2 = "Kaczor";

            //act 
            //assert
            Assert.AreNotEqual(str1, str2);
        }

        [Test]
        public void TestReferenceTypResult()
        {
            // arrange
            var employee1  = new Employee("Daniel", "Kozlowski", 30);
            var employee2 = new Employee("Marian", "Kruk", 18);

            //act
            //assert
            Assert.AreNotEqual(employee1, employee2);
        }
        private Employee GetEmployee(string surname)
        {
            return new Employee(surname);
        }
    }
}
