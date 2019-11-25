using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Service.Models
{
    [Table("CarDetailsTable")]
    public class CarDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public Int64 CustomerMobile { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        [Required]
        public string CarName { get; set; }
        [Required]
        public string CarModelNo { get; set; }
        [Required]
        public string CarNumber { get; set; }
        [Required]
        public string CarIssue { get; set; }
        [Required]
        public DateTime ServiceDate { get; set; }
        [Required]
        public DateTime ReturnDate { get; set; }
    }
}