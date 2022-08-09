using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Aiminfomatics.Widgets
{
    public class NewsletterSubscriptionSubscribeModel
    {
        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [DisplayName("Want to stay up to date? Please leave us your email address.")]
        [MaxLength(250, ErrorMessage = "Maximum allowed length of the email is {1}")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Check CheckBOx")]
        public bool Remember { get; set; }



    }
}