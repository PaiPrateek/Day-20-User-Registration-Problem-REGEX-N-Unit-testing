using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem_RegexTesting
{
    public class ExceptionHandling
    {
        
        public bool Validate_FirstName_Exception(string firstName)
        {
            //First name starts with capital and should have min 3 characters
            string FirstNamePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";
            Match resultFirstName = Regex.Match(firstName, FirstNamePattern);
            if (resultFirstName.Success)
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRSTNAME, "Entered First Name is Invalid :");
            }
        }

        public bool Validate_LastName_Exception(string lastName)
        {
            //Last name starts with capital and should have min 3 characters
            string LastNamePattern = @"^[A-Z]{1}[a-zA-Z]{2,}$";
            Match resultLastName = Regex.Match(lastName, LastNamePattern);
            if (resultLastName.Success)
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LASTNAME, "Entered Last Name is Invalid :");
            }
        }

        public bool Validate_Email_Exception(string email)
        {
            //Email Pattern 
            string EmailPattern = @"^([A-Za-z]{3,}([.a-z]*)[@][a-z]{2,}[.][a-z]{2,3}([.a-z]*))$";
            Match resultEmail = Regex.Match(email, EmailPattern);
            if (resultEmail.Success)
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "Entered E-Mail is Invalid :");
            }
        }

        public bool Validate_MobileNumber_Exception(string mobileNumber)
        {
            //Mobile Number  - Country code follwed by space and 10 Digit Number
            string MobileNumberPattern = @"^[1-9]{2,}[\s][6-9]{1}[0-9]{9}$";
            Match resultMobileNumber = Regex.Match(mobileNumber, MobileNumberPattern);
            if (resultMobileNumber.Success)
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MOBILENUMBER, "Entered Mobile Number is Invalid :");
            }
        }

        public bool Validate_Password_Contains_Min_8_Characters_Exception(string password)
        {
            //Password  - Min 8 Characters
            string PasswordPattern = @"^[a-zA-Z]{8,}$";
            Match resultPassword = Regex.Match(password, PasswordPattern);
            if (resultPassword.Success)
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD_MIN8_CHAR, "Entered Password should have atlast 8 Characters:");
            }
        }
        public bool Validate_Password_Contains_Min_8_Characters_should_have_atleast_1_uppercase_Exception(string password)
        {
            //Password  - Min 8 Characters and should have atleast 1 upeer case
            string PasswordPattern = @"^(?=.*[A-Z])[a-zA-Z]{8,}$";
            Match resultPassword = Regex.Match(password, PasswordPattern);
            if (resultPassword.Success)
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD_MIN8_CHAR_1UPPERCASE, "Entered Password should have atleast 8 Characters and Atleast 1 upper Case:");
            }
        }

        public bool Validate_Password_Contains_Min_8_Characters_should_have_atleast_1_uppercase_1_NumericNumber_Exception(string password)
        {
            //Password  - Min 8 Characters and should have atleast 1 upeer case, 1 Numeric Number 
            string PasswordPattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[a-z]).{8,}$";

            Match resultPassword = Regex.Match(password, PasswordPattern);
            if (resultPassword.Success)
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD_MIN8_CHAR_1UPPERCASE_1NUMERICNUMBER, "Entered Password should have atleast 8 Characters, 1 Upper case and 1 Numeric Number:");
            }
        }

        public bool Validate_Password_Contains_Min_8_Characters_should_have_atleast_1_uppercase_1_NumericNumber_and_has_exactly_1_SpecialCharacter_Exception(string password)
        {
            //Password  - Min 8 Characters and should have atleast 1 upeer case, 1 Numeric Number 
            string PasswordPattern = @"^(?=.*[A-Z])(?=.*[@#$!%^&-+=()])(?=.*[0-9])(?=.*[a-z]).{8,}$";

            Match resultPassword = Regex.Match(password, PasswordPattern);
            if (resultPassword.Success)
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD_MIN8_CHAR_1UPPERCASE_1NUMERICNUMBER_1SPEC_CHAR, "Entered Password should have atlast 8 Characters, 1 Upper Case, 1 Numeric number and has exact 1 Special Character:");
            }
        }

        public bool Validate_Sample_Emails_Exception(string sampleEmail)
        {
            //Email Pattern 
            string SampleEmailPattern = @"^([a-z]{3}([\.\+\-0-9]*)@[a-z0-9]{1,}.[a-z]{3,}[.a-z]*)";

            Match resultSampleEmail = Regex.Match(sampleEmail, SampleEmailPattern);
            if (resultSampleEmail.Success)
            {
                return true;
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_SAMPLE_EMAIL, "Entered Email is Invalid");
            }
        }
    }
}
