using System;
using System.ComponentModel.DataAnnotations;

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

        [Required]
        [StringLength(12)]
        public string BillerId { get; set; }
        public Staff Biller { get; set; }

        public DateTime DayOfActionBookField { get; set; }
        public DateTime DayOfBookField { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }


        public DateTime DayOfBill { get; set; }
        public decimal BookFieldFee { get; set; }
        public decimal ProductFee { get; set; }
        public decimal ChangeFee { get; set; }
        public decimal VatFee { get; set; }
        public decimal TotalFee { get; set; }
        public Boolean Condition { get; set; }
        public string Note { get; set; }
    }
}
