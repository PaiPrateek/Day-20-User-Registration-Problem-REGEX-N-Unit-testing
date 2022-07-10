using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem_RegexTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem - Regex Unit Testing");
            Console.WriteLine("\n");

            Program P = new Program();

            //Validation for First Name
            P.Validate_FirstName("Prateek");

            //Validation for Last Name
            P.Validate_LastName("Pai");

            //Validation for Email
            P.Validate_Email("prateek.pai@gmail.co.in");

            //Validation for Mobile Number
            P.Validate_MobileNumber("91 9945007207");
        }

        public bool Validate_FirstName(string firstName)
        {
            //First name starts with capital and should have min 3 characters
            string FirstNamePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";

            return Regex.IsMatch(firstName,FirstNamePattern);
        }

        public bool Validate_LastName(string lastName)
        {
            //Last name starts with capital and should have min 3 characters
            string LastNamePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";

            return Regex.IsMatch(lastName, LastNamePattern);
        }

        public bool Validate_Email(string email)
        {
            //Email Pattern 
            string EmailPattern = @"^([A-Za-z]{3,}([.a-z]*)[@][a-z]{2,}[.][a-z]{2,3}([.a-z]*))$";

            return Regex.IsMatch(email, EmailPattern);
        }

        public bool Validate_MobileNumber(string mobileNumber)
        {
            //Mobile Number  - Country code follwed by space and 10 Digit Number
            string MobileNumberPattern = @"^[1-9]{2,}[\s][6-9]{1}[0-9]{9}$";

            return Regex.IsMatch(mobileNumber, MobileNumberPattern);
        }
    }
}
