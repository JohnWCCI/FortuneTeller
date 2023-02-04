namespace FortuneTest
{
    public class Tests
    {
        private Person testPerson;

        [SetUp]
        public void Setup()
        {
           testPerson = new Person();
        }

        [Test]
        public void First_Name_Test_for_Empty()
        {
           // Assert.Pass(!string.IsNullOrEmpty(testPerson.);
        }
    }
}