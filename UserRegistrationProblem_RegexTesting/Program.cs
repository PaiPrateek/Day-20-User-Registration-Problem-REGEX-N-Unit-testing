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

            ExceptionHandling exception = new ExceptionHandling();
            Program P = new Program();

            //Validation for First Name
            P.Validate_FirstName("Prateek");

            //Validation for Last Name
            P.Validate_LastName("Pai");

            //Validation for Email
            P.Validate_Email("prateek.pai@gmail.co.in");

            //Validation for Mobile Number
            P.Validate_MobileNumber("91 9945007207");

            //Validation for Password
            P.Validate_Password_Contains_Min_8_Characters("Password");

            //Validation for Password
            P.Validate_Password_Contains_Min_8_Characters_should_have_atleast_1_uppercase("paSSword");

            //Validation for Password
            P.Validate_Password_Contains_Min_8_Characters_should_have_atleast_1_uppercase_1_NumericNumber("paSSword123");

            //Validation for Password
            P.Validate_Password_Contains_Min_8_Characters_should_have_atleast_1_uppercase_1_NumericNumber_and_has_exactly_1_SpecialCharacter("Password@123");

            //Validation for Email
            P.Validate_Sample_Emails("abc.100@yahoo.com");
            //*************************************************************************************************//
            //Validation for First Name Exception
            exception.Validate_FirstName_Exception("Pk");

            //Validation for Last Name Exception
            exception.Validate_LastName_Exception("Pi");

            //Validation for Email Exception
            exception.Validate_Email_Exception("gmail.co.in");

            //Validation for Mobile Number Exception
            exception.Validate_MobileNumber_Exception("994500");

            //Validation for Password Exception
            exception.Validate_Password_Contains_Min_8_Characters_Exception("word");

            //Validation for Password Exception
            exception.Validate_Password_Contains_Min_8_Characters_should_have_atleast_1_uppercase_Exception("SS");

            //Validation for Password Exception
            exception.Validate_Password_Contains_Min_8_Characters_should_have_atleast_1_uppercase_1_NumericNumber_Exception("word");

            //Validation for Password Exception
            exception.Validate_Password_Contains_Min_8_Characters_should_have_atleast_1_uppercase_1_NumericNumber_and_has_exactly_1_SpecialCharacter_Exception("Pass");

            //Validation for Email Exception
            exception.Validate_Sample_Emails_Exception("abc");
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

        public bool Validate_Password_Contains_Min_8_Characters(string password)
        {
            //Password  - Min 8 Characters
            string PasswordPattern = @"^[a-zA-Z]{8,}$";

            return Regex.IsMatch(password, PasswordPattern);
        }

        public bool Validate_Password_Contains_Min_8_Characters_should_have_atleast_1_uppercase(string password)
        {
            //Password  - Min 8 Characters and should have atleast 1 upeer case
            string PasswordPattern = @"^(?=.*[A-Z])[a-zA-Z]{8,}$";

            return Regex.IsMatch(password, PasswordPattern);
        }

        public bool Validate_Password_Contains_Min_8_Characters_should_have_atleast_1_uppercase_1_NumericNumber(string password)
        {
            //Password  - Min 8 Characters and should have atleast 1 upeer case, 1 Numeric Number 
            string PasswordPattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[a-z]).{8,}$";

            return Regex.IsMatch(password, PasswordPattern);
        }

        public bool Validate_Password_Contains_Min_8_Characters_should_have_atleast_1_uppercase_1_NumericNumber_and_has_exactly_1_SpecialCharacter(string password)
        {
            //Password  - Min 8 Characters and should have atleast 1 upeer case, 1 Numeric Number 
            string PasswordPattern = @"^(?=.*[A-Z])(?=.*[@#$!%^&-+=()])(?=.*[0-9])(?=.*[a-z]).{8,}$";

            return Regex.IsMatch(password, PasswordPattern);
        }

        public bool Validate_Sample_Emails(string sampleEmail)
        {
            //Email Pattern 
            string SampleEmailPattern = @"^([a-z]{3}([\.\+\-0-9]*)@[a-z0-9]{1,}.[a-z]{3,}[.a-z]*)";

            return Regex.IsMatch(sampleEmail, SampleEmailPattern);
        }
    }
}
