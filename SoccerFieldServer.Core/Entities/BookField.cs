using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerFieldServer.Core.Entities
{
    public class BookField
    {
        [Key]
        [StringLength(12)]
        public string Id { get; set; }

        [Required]
        [StringLength(12)]
        public string SoccerFieldId { get; set; }
        public SoccerField SoccerField { get; set; }

        [Required]
        [StringLength(12)]
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required]
        [StringLength(12)]
        public string StaffId { get; set; }
        public Staff Staff { get; set; }

        [StringLength(12)]
        public string BillerId { get; set; }
        public Staff Biller { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DayOfActionBookField { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DayOfBookField { get; set; }

        [Required]
        public TimeSpan TimeStart { get; set; }

        [Required]
        public TimeSpan TimeEnd { get; set; }

        [Column(TypeName = "date")]
        public DateTime DayOfBill { get; set; }

        public decimal BookFieldFee { get; set; }
        public decimal ProductFee { get; set; }
        public decimal ChangeFee { get; set; }
        public decimal VatFee { get; set; }
        public decimal TotalFee { get; set; }

        [Required]
        public Boolean Status { get; set; }

        [StringLength(50)]
        public string Note { get; set; }
    }
}
