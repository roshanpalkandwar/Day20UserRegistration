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
            string expected = "roshanpalkan";

            PassWordRule1 passWordRule1 = new PassWordRule1("roshanpalkan");
            string actual = passWordRule1.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]

        public void TestPasswordRuleTwo()
        {
            string expected = "RoshanPalkandwar";

            PassWordRule2 passWordRule2 = new PassWordRule2("RoshanPalkandwar");
            string actual = passWordRule2.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void TestPasswordRuleThree()
        {
            string expected = "RoshanPalkandwar123";

            PassWordRule3 passWordRule3 = new PassWordRule3("RoshanPalkandwar123");
            string actual = passWordRule3.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void TestPasswordRuleFour()
        {
            string expected = "RoshanPalkandwar@123";

            PassWordRules4 passWordRules4 = new PassWordRules4("RoshanPalkandwar@123");
            string actual = passWordRules4.ValidatePassword();

            Assert.AreEqual(expected, actual);
            Console.WriteLine(actual);
        }
        [TestMethod]
        public void TestEmailSamples()
        {
            string expected1 = "abc.100@abc.com.au";
            string expected2 = "abc@.com.my";

            EmailSample emailSample = new EmailSample("abc.100@abc.com.au");
            string actual1 = emailSample.ValidateEmail();

            EmailSample emailSample1 = new EmailSample("abc@.com.my");
            string actual2 = emailSample1.ValidateEmail();

            Assert.AreEqual(expected1, actual1);
            Assert.AreNotEqual(expected2, actual2);
            Console.WriteLine(actual1);
            Console.WriteLine(actual2);
        }


    }
}