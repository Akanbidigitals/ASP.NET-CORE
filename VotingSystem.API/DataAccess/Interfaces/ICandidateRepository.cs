using VotingSystem.API.Domain.DTOs.Candidates;
using VotingSystem.API.Domain.Models;

namespace VotingSystem.API.DataAccess.Interfaces
{
    public interface ICandidateRepository
    {
        Task<CandidateGetDto> AddCandidate(CandidateCreateDto newCandidate);

        Task<Candidate> GetCandiateById(int candidate_id);

        Task<IEnumerable<Candidate>> GetAllCandidate();

        Task <string> DeleteCandidate(int candidate_id);

        Task<Candidate> UpdateCandidate(Candidate candidate_to_update);


    }
}
