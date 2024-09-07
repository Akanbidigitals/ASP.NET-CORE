using System.ComponentModel.DataAnnotations;

namespace VotingSystem.API.Domain.DTOs.Candidates
{
    public class CandidateGetDto
    {
        
        public int Id { get; set; }
       
        public string Email { get; set; } = "";
       
        public string FirstName { get; set; } = "";
       
        public string LastName { get; set; } = "";

    }
}
