using Microsoft.EntityFrameworkCore;
using VotingSystem.API.DataAccess.DataContext;

namespace VotingSystem.API.DataAccess.Utilities
{
    public class DataBaseModelValidator
    {
        private readonly VotingSystemContext _database;

        public DataBaseModelValidator(VotingSystemContext database)
        {
            _database = database;
        }
        public async Task<bool> CheckExistingNameAndEmail(string firstname,string lastname,string email)
        {
            try
            {

            var checkCredentials = await _database.Candidates.
                AnyAsync(x => x.FirstName.ToLower() + x.LastName.ToLower() == x.LastName.ToLower() + firstname.ToLower()  
                || x.LastName.ToLower() + x.FirstName.ToLower() == x.FirstName.ToLower() + lastname.ToLower() 
                || x.Email.ToLower()== email.ToLower());

                if (checkCredentials)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
