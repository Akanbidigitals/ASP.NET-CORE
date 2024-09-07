using VotingSystem.API.DataAccess.DataContext;
using VotingSystem.API.DataAccess.Interfaces;
using VotingSystem.API.DataAccess.Utilities;
using VotingSystem.API.Domain.DTOs.Candidates;
using VotingSystem.API.Domain.Models;

namespace VotingSystem.API.DataAccess.Repositories
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly VotingSystemContext _database;
        public CandidateRepository(VotingSystemContext database)
        {
            _database = database;
        }
        public async Task<CandidateGetDto> AddCandidate(CandidateCreateDto newCandidate)
        {
            try
            {
                var input_validation = InputValidation.FormatValidationForFirstNameLastNameAndEmail(newCandidate.FirstName, newCandidate.LastName, newCandidate.Email);
                if (!input_validation)
                {
                    throw new FormatException("Wrong format for credential");
                }
                else
                {

                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<string> DeleteCandidate(int candidate_id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Candidate>> GetAllCandidate()
        {
            throw new NotImplementedException();
        }

        public Task<Candidate> GetCandiateById(int candidate_id)
        {
            throw new NotImplementedException();
        }

        public Task<Candidate> UpdateCandidate(Candidate candidate_to_update)
        {
            throw new NotImplementedException();
        }
    }
}
