using NUnit.Framework;
using System.Text.RegularExpressions;
using UserRegistrationProblem_RegexTesting;

namespace TestProject
{
    public class Tests
    {
        public Program program;

        [SetUp]
        public void Setup()
        {
            //Arrange 
            program = new Program();
        }

        [Test]
        //Unit test for validating the First Name
        public void Check_Validation_for_FirstName()
        {
            //Act
            string firstName = "Prateek";

            var result = program.Validate_FirstName(firstName);

            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        //Unit test for validating the Last Name
        public void Check_Validation_for_LastName()
        {
            //Act
            string lastName = "Pai";

            var result = program.Validate_LastName(lastName);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        //Unit test for validating the Email
        public void Check_Validation_for_Email()
        {
            //Act
            string email = "prateek.pai@gmail.co.in";

            var result = program.Validate_Email(email);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        //Unit test for validating the Mobile Number
        public void Check_Validation_for_MobileNumber()
        {
            //Act
            string mobileNumber = "91 9945007207";

            var result = program.Validate_MobileNumber(mobileNumber);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        //Unit test for validating the Password
        public void Check_Validation_for_password_Contains_Min_8_Characters()
        {
            //Act
            string password = "Password";

            var result = program.Validate_Password_Contains_Min_8_Characters(password);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        //Unit test for validating the Password
        public void Check_Validation_for_password_Contains_Min_8_Characters_should_have_atleast_1_uppercase()
        {
            //Act
            string password = "paSSword";

            var result = program.Validate_Password_Contains_Min_8_Characters_should_have_atleast_1_uppercase(password);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        //Unit test for validating the Password
        public void Check_Validation_for_password_Contains_Min_8_Characters_should_have_atleast_1_uppercase_1_NumericNumber()
        {
            //Act
            string password = "paSSword123";

            var result = program.Validate_Password_Contains_Min_8_Characters_should_have_atleast_1_uppercase_1_NumericNumber(password);

            //Assert
            Assert.IsTrue(result);
        }
    }
}