namespace FortuneTest
{
    [TestFixture]
    public class UserTest
    {
        private User testUser;

        [SetUp]
        public void Setup()
        {
           testUser = new User();
        }

        [Test]
        public void First_Name_Test_for_Empty()
        {
           Assert.IsNotEmpty(testUser.FirstName,"FirstName can not be Empty.");
        }
        [Test]
        public void Last_Name_Test_for_Empty()
        {
            Assert.IsNotEmpty(testUser.LastName, "LastName can not be Empty.");
        }
    }
}