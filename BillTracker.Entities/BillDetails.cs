using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace BillTracker.Entities
{
    public class BillDetails
    {
        [Key]
       
        public String BillId { get; set; }

        
        [Required]
        [Display(Name = "Bill Title")]
        [MaxLength(50, ErrorMessage = "Bill Title Cannot exceed 50 Characters")]
        public String Title { get; set; }

        
        [Required]
        [Display(Name = "Bill Category")]
        [MaxLength(50, ErrorMessage = "Bill Category Cannot exceed 50 Characters")]
        public BillCategory Catagory { get; set; }

        
        [Required]
        [Display(Name = "Bill Amount")]
        public long Amount { get; set; }

       
        [Required]
        [Display(Name = "Bill Date Of Entry")]
       public DateTime? DateOfEntry{ get; set; }

        
        [Required]
        [Display(Name = "Bill Due Date")]
        public DateTime? DueDate { get; set; }

       
        [Required]
        [Display(Name = "Bill Payment Mode")]
        public BillPaymentMode PaymentMode { get; set; }

       [Required]
        [Display(Name = "Bill Status")]
        public BillStatus Status { get; set; }

    }
}
