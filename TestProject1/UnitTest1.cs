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
        [TestMethod]
        public void TestMobileNumber()
        {
            string expected = "+91 7123456789";

            Mobile mobile = new Mobile("+91 7123456789");
            string actual = mobile.ValideMobileNumber();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void TestPasswordRuleOne()
        {
            string expected = "roanaksharma";

            PassWordRule1 passWordRule1 = new PassWordRule1("roanaksharma");
            string actual = passWordRule1.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }

        
    }
}