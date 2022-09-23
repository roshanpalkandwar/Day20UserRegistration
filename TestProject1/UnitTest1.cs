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
        [TestMethod]
        public void TestLastName()
        {
            string expected = "Roshan";

            LastName lastName = new LastName("Roshan");
            string actual = lastName.ValidateLastName();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void TestEmail()
        {
            string expected = "abc.xyz@bl.co.in";

            Email email = new Email("abc.xyz@bl.co.in");
            string actual = email.ValidateEmail();

            Assert.AreEqual(expected , actual);
            Console.WriteLine(actual);

            
            
        }
    }
}