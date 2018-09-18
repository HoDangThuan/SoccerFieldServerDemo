using System;
using System.ComponentModel.DataAnnotations;

namespace SoccerFieldServer.Core.Entities
{
    public class AdminWebsite
    {
        [Key]
        [StringLength(6)]
        public string Id { get; set; }

        public string Name { get; set; }
        public string PassWord { get; set; }
    }
}
