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

            P.Validate_FirstName("Prateek");
        }

        public bool Validate_FirstName(string firstName)
        {
            //First name starts with capital and should have min 3 characters
            string FirstNamePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";

            return Regex.IsMatch(firstName,FirstNamePattern);
        }
    }
}
