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
    }
}