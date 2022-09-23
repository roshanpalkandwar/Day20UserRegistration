using Day20UserRegistration;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "Roshan";

            FirstName firstname = new FirstName("Roshan");
            string actual = firstname.ValidateFirstName();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);

        }
    }
}