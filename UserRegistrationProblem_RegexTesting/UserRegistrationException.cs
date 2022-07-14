using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem_RegexTesting
{
    public class UserRegistrationException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRSTNAME, INVALID_LASTNAME, INVALID_MOBILENUMBER, INVALID_EMAIL, INVALID_PASSWORD_MIN8_CHAR,
            INVALID_PASSWORD_MIN8_CHAR_1UPPERCASE, INVALID_PASSWORD_MIN8_CHAR_1UPPERCASE_1NUMERICNUMBER,
            INVALID_PASSWORD_MIN8_CHAR_1UPPERCASE_1NUMERICNUMBER_1SPEC_CHAR, INVALID_SAMPLE_EMAIL
        }
        private readonly ExceptionType exceptionType;

        public UserRegistrationException(ExceptionType exceptionType, string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
