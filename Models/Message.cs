using System.ComponentModel.DataAnnotations;

namespace UserApplication.Models
{
    public class Message
    {
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "veld is verplicht")]
        public string NameOfSender { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "veld is verplicht")]
        public string MessageBody { get; set; }

        [Required(ErrorMessage = "veld is verplicht")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
