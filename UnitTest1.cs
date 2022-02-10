using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration_LambdaExp;

namespace UnitTest_User_Registration
{
    [TestClass]
    public class UnitTest1
    {
        //UC 10-11 : MSTest to check for valid and invalid names
        [TestMethod]
        [DataRow("Akash")]
        public void ValidateFirstName(string name)
        {
            string firstNamePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";
            try
            {
                bool actual = Validation.IsValid(name, firstNamePattern);
                Assert.AreEqual(true, actual);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Exception: Invalid Details Entered", e.Message);
            }
        }
        //UC 10-11 : MSTest to check for valid and invalid email id
        [TestMethod]
        [DataRow("akash.singh123@gmail.com")]
        [DataRow("akash.@gmail")]
        public void ValidateEmailId(string emailId)
        {
            string emailIdPattern = @"^[a-zA-Z0-9]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.][a-zA-Z]{3})+([.][a-zA-Z]{2})?$";
            try
            {
                bool actual = Validation.IsValid(emailId, emailIdPattern);
                Assert.AreEqual(true, actual);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Exception: Invalid Details Entered", e.Message);
            }
        }
        //UC 10-11 : MSTest to check for valid and invalid Mobile Number
        [TestMethod]
        [DataRow("91 4566784567")]
        [DataRow("11223")]
        public void ValidateMobileNumber(string number)
        {
            string mobileNumberPattern = @"^[0-9]{2}[ ][0-9]{10}$";
            try
            {
                bool actual = Validation.IsValid(number, mobileNumberPattern);
                Assert.AreEqual(true, actual);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Exception: Invalid Details Entered", e.Message);
            }
        }
        //UC 10-11 : MSTest to check for valid and invalid Password
        [TestMethod]
        [DataRow("A12@helloworld")]
        [DataRow("wrongpassword")]
        public void ValidatePasswordTest(string password)
        {
            string passwordPattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";
            try
            {
                bool actual = Validation.IsValid(password, passwordPattern);
                Assert.AreEqual(true, actual);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Exception: Invalid Details Entered", e.Message);
            }
        }
    }
}