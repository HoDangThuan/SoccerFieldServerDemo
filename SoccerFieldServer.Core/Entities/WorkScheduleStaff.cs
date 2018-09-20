using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SoccerFieldServer.Core.Enums;

namespace SoccerFieldServer.Core.Entities
{
    public class WorkScheduleStaff
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(12)]
        public string StaffId { get; set; }
        public Staff Staff { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "date")]
        public DateTime Day { get; set; }

        [Key]
        [Column(Order = 2)]
        public EnumShift Shift { get; set; }

        [Required]
        public Boolean Status { get; set; }

        [StringLength(50)]
        public string Note { get; set; }
    }
}
