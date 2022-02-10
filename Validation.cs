using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_LambdaExp
{
    //UC 13 : Refactor to use Lambda Exp to validate user details
    public class Validation
    {
        //Creating a Lambda Expression to validate the details entered by the user by matching the entry with the corresponding Regular Expression
        //Func validate declared which returns true if valid entry otherwise false.
        public static Func<string, string, bool> validate = (userEntry, pattern) => Regex.IsMatch(userEntry, pattern);

        //creating a method to validate the entered user data with the corresponding Regular Expression
        //if matches then returns true
        //if does not matches then throw custom exception 
        public static bool IsValid(string userValue, string pattern)
        {
            if (validate(userValue, pattern))
                return true;
            else
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_DETAILS, "Exception: Invalid Details Entered");
            }
        }
    }
}
