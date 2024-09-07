using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VotingSystem.API.Domain.Models
{
    public class Vote
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey(nameof(Candidate))]
        public int CandidateId { get; set; } 
        public int VoteCount { get; set; } = 0;

    }
}
