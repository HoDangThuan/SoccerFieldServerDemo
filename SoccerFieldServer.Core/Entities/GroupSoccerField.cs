using System;
using System.ComponentModel.DataAnnotations;

namespace SoccerFieldServer.Core.Entities
{
    public class GroupSoccerField
    {
        [Key]
        [StringLength(6)]
        public string Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public double PercentVAT { get; set; }
        public double PercentPunish { get; set; }
        public double PercentRushHour { get; set; }
        public Boolean Condition { get; set; }
        public string Note { get; set; }
    }
}