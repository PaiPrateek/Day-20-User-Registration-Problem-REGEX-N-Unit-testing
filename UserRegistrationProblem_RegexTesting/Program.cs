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
    }
}
