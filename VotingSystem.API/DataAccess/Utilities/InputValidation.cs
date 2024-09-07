using System.Text.RegularExpressions;

namespace VotingSystem.API.DataAccess.Utilities
{
    public partial class  InputValidation
    {
        public static bool FormatValidationForFirstNameLastNameAndEmail(string firstName, string lastName,string email)
        {
            if(FirstNameRegex().IsMatch(firstName) && FirstNameRegex().IsMatch(lastName) && EmailRegex().IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [GeneratedRegex("^[a-zA-Z]+$")]
        private static partial Regex FirstNameRegex();
        [GeneratedRegex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$")]
        private static partial Regex EmailRegex();
    }
}
