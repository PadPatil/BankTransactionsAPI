using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactionsAPI.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(12, ErrorMessage = "An account number must be 12 numbers at most.")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "This field is required.")]

        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This field is required.")]
        public String BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(11, ErrorMessage = "A SWIFT Code must be 11 numbers at most.")]
        public String SWIFTCode { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime Date { get; set; }

    }
}
