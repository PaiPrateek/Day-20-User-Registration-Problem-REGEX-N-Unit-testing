using NUnit.Framework;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UserRegistrationProblem_RegexTesting;

namespace TestProject
{
    public class Tests1
    {
        public ExceptionHandling exceptionHandling;

        [SetUp]
        public void Setup()
        {
            //Arrange 
            exceptionHandling = new ExceptionHandling();

        }

        [Test]
        //Unit test for validating the First Name
        public void Check_Validation_for_FirstName_Exception()
        {
            //Act
            string message = "Entered First Name is Invalid :";
            try
            {
                string firstName = "Pr";
                var result = exceptionHandling.Validate_FirstName_Exception(firstName);
            }
            catch (UserRegistrationException ex)

            {
                //Assert
                Assert.AreEqual(message, ex.Message);
            }
        }
        [Test]
        //Unit test for validating the Last Name
        public void Check_Validation_for_LastName_Exception()
        {
            string message = "Entered Last Name is Invalid :";
            try
            {
                string firstName = "Pa";
                var result = exceptionHandling.Validate_LastName_Exception(firstName);
            }
            catch (UserRegistrationException ex)

            {
                //Assert
                Assert.AreEqual(message, ex.Message);
            }
        }
        [Test]
        //Unit test for validating the Email
        public void Check_Validation_for_Email_Exception()
        {
            //Act
            string message = "Entered E-Mail is Invalid :";
            try
            {
                string email = "pai";
                var result = exceptionHandling.Validate_Email_Exception(email);
            }
            catch (UserRegistrationException ex)

            {
                //Assert
                Assert.AreEqual(message, ex.Message);
            }

        }

        [Test]
        //Unit test for validating the Mobile Number
        public void Check_Validation_for_MobileNumber_Exception()
        {
            //Act
            string message = "Entered Mobile Number is Invalid :";
            try
            {
                string mobileNumber = "9945007";
                var result = exceptionHandling.Validate_MobileNumber_Exception(mobileNumber);
            }
            catch (UserRegistrationException ex)

            {
                //Assert
                Assert.AreEqual(message, ex.Message);
            }
        }

        [Test]
        //Unit test for validating the Password
        public void Check_Validation_for_password_Contains_Min_8_Characters_Exception()
        {
            //Act
            string message = "Entered Password should have atlast 8 Characters:";
            try
            {
                string password = "prateek";
                var result = exceptionHandling.Validate_Password_Contains_Min_8_Characters_Exception(password);
            }
            catch (UserRegistrationException ex)

            {
                //Assert
                Assert.AreEqual(message, ex.Message);
            }
        }

        [Test]
        //Unit test for validating the Password
        public void Check_Validation_for_password_Contains_Min_8_Characters_should_have_atleast_1_uppercase_Exception()
        {
            //Act
            string message = "Entered Password should have atleast 8 Characters and Atleast 1 upper Case:";
            try
            {
                string password = "prateek";
                var result = exceptionHandling.Validate_Password_Contains_Min_8_Characters_should_have_atleast_1_uppercase_Exception(password);
            }
            catch (UserRegistrationException ex)

            {
                //Assert
                Assert.AreEqual(message, ex.Message);
            }
        }

        [Test]
        //Unit test for validating the Password
        public void Check_Validation_for_password_Contains_Min_8_Characters_should_have_atleast_1_uppercase_1_NumericNumber_Exception()
        {
            //Act
            string message = "Entered Password should have atleast 8 Characters, 1 Upper case and 1 Numeric Number:";
            try
            {
                string password = "prateek";
                var result = exceptionHandling.Validate_Password_Contains_Min_8_Characters_should_have_atleast_1_uppercase_1_NumericNumber_Exception(password);
            }
            catch (UserRegistrationException ex)

            {
                //Assert
                Assert.AreEqual(message, ex.Message);
            }
        }

        [Test]
        //Unit test for validating the Password
        public void Check_Validation_for_password_Contains_Min_8_Characters_should_have_atleast_1_uppercase_1_NumericNumber_and_has_exactly_1_specialCharacter_Exception()
        {
            //Act
            string message = "Entered Password should have atlast 8 Characters, 1 Upper Case, 1 Numeric number and has exact 1 Special Character:";
            try
            {
                string password = "prateek";
                var result = exceptionHandling.Validate_Password_Contains_Min_8_Characters_should_have_atleast_1_uppercase_1_NumericNumber_and_has_exactly_1_SpecialCharacter_Exception(password);
            }
            catch (UserRegistrationException ex)

            {
                //Assert
                Assert.AreEqual(message, ex.Message);
            }
        }

        [Test]
        //Unit test for validating the Sample Email
        public void Check_Validation_for_Sample_Emails_Exception()
        {
            //Act
            string message = "Entered Email is Invalid";
            try
            {
                string samplemail = "prateek";
                var result = exceptionHandling.Validate_Sample_Emails_Exception(samplemail);
            }
            catch (UserRegistrationException ex)

            {
                //Assert
                Assert.AreEqual(message, ex.Message);
            }
        }
    }
}
