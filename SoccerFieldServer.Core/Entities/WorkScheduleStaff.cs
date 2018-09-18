using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerFieldServer.Core.Entities
{
    public class WorkScheduleStaff
    {
        [Key, Column(Order = 0)]
        [StringLength(12)]
        public string StaffId { get; set; }
        public Staff Staff { get; set; }

        [Key, Column(Order = 1)]
        public DateTime Day { get; set; }

        [Key, Column(Order = 2)]
        public int Shift { get; set; }

        public Boolean Condition { get; set; }
        public string Note { get; set; }
    }
}
