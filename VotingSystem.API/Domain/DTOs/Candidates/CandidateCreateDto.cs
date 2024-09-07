using System.ComponentModel.DataAnnotations;

namespace VotingSystem.API.Domain.DTOs.Candidates
{
    public class CandidateCreateDto
    {
        public string Email { get; set; } = "";
        
        public string FirstName { get; set; } = "";
       
        public string LastName { get; set; } = "";
    }
}
