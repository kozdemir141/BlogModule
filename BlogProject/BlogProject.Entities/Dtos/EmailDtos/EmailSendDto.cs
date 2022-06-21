using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlogProject.Entities.Dtos.EmailDtos
{
	public class EmailSendDto
	{
        [DisplayName("Your Name")]
        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(60,ErrorMessage = "Name Can Not Be More Than {1} Charecter")]
        [MinLength(1, ErrorMessage = "Name Can Not Be Less Than {1} Charecter")]
        public string Name { get; set; }

        [DisplayName("E-Mail")]
        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(100, ErrorMessage = "E-Mail Can Not Be More Than {1} Charecter")]
        [MinLength(10, ErrorMessage = "E-Mail Can Not Be Less Than {1} Charecter")]
        public string Email { get; set; }

        [DisplayName("Subject")]
        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(125, ErrorMessage = "Subject Can Not Be More Than {1} Charecter")]
        [MinLength(5, ErrorMessage = "Subject Can Not Be Less Than {1} Charecter")]
        public string Subject { get; set; }

        [DisplayName("Your Message")]
        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(1200, ErrorMessage = "Message Can Not Be More Than {1} Charecter")]
        [MinLength(10, ErrorMessage = "Message Can Not Be Less Than {1} Charecter")]
        public string Message { get; set; }
    }
}

