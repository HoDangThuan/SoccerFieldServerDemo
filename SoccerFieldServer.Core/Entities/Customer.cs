using System;
using System.ComponentModel.DataAnnotations;

namespace SoccerFieldServer.Core.Entities
{
    public class Customer
    {
        [Key]
        [StringLength(12)]
        public string Id { get; set; }

        public string Name { get; set; }
        public string PassWord { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BankAcount { get; set; }
    }
}
