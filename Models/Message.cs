using System.ComponentModel.DataAnnotations;

namespace UserApplication.Models
{
    public class Message
    {
        public Guid Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "verplicht*" )]
        public string NameOfSender { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "verplicht*")]
        public string MessageBody { get; set; }

        [Required(ErrorMessage = "verplicht*")]
        [DataType(DataType.PhoneNumber)]
        [Phone]

        public string PhoneNumber { get; set; }

        public bool IsAnswered { get; set; }


    }
}
