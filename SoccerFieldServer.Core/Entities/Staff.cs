using System;
using System.ComponentModel.DataAnnotations;

namespace SoccerFieldServer.Core.Entities
{
    public class Staff
    {
        [Key]
        [StringLength(12)]
        public string Id { get; set; }

        public string Name { get; set; }
        public string PassWord { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Regency { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BankAcount { get; set; }

        [Required]
        [StringLength(6)]
        public string GroupSoccerFieldId { get; set; }
        public GroupSoccerField GroupSoccerField { get; set; }
    }
}
