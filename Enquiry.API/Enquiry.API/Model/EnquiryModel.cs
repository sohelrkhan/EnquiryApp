using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Enquiry.API.Model
{
    [Table("Enquiry")]
    public class EnquiryModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int enquiryId { get; set; }

        [Required]
        public int enquiryTypeId { get; set; }

        [Required]
        public int enquiryStatusId { get; set; }

        [Required]
        public string customerName { get; set; } = string.Empty;

        [Required]
        public string mobileNo { get; set; } = string.Empty;

        public string email { get; set; } = string.Empty;

        [Required]
        public string message { get; set; } = string.Empty;

        [Required]
        public DateTime createdDate { get; set; }
        public string resolution { get; set; } = string.Empty;
    }
}
