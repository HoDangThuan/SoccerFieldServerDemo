using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SoccerFieldServer.Core.Entities
{
    public class GroupSoccerField
    {
        [Key]
        [StringLength(6)]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Area { get; set; }

        [Required]
        [DefaultValue("05:00:00 AM")]
        public TimeSpan OpenTime { get; set; }

        [Required]
        [DefaultValue("11:00:00 PM")]
        public TimeSpan CloseTime { get; set; }

        [Required]
        [DefaultValue(0)]
        public double PercentVAT { get; set; }

        [Required]
        [DefaultValue(0)]
        public double PercentPunish { get; set; }

        [Required]
        [DefaultValue(0)]
        public double PercentRushHour { get; set; }

        [Required]
        [DefaultValue(true)]
        public Boolean Status { get; set; }

        [DefaultValue("Hoạt động tốt")]
        [StringLength(50)]
        public string Note { get; set; }
    }
}