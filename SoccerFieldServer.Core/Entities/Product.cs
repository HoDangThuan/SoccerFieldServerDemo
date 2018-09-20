using System;
using System.ComponentModel.DataAnnotations;

namespace SoccerFieldServer.Core.Entities
{
    public class Product
    {
        [Key]
        [StringLength(12)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Amount { get; set; }
        public decimal Price { get; set; }

        [Required]
        public Boolean Status { get; set; }

        [StringLength(50)]
        public string Note { get; set; }

        [Required]
        [StringLength(6)]
        public string GroupSoccerFieldId { get; set; }
        public GroupSoccerField GroupSoccerField { get; set; }
    }
}