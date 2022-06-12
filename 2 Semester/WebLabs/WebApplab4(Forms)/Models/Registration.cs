namespace WebApplab4_Forms_.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Registration
    {
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public bool gender { get; set; }

        [Required]
        public string birthDay { get; set; }
        [Required]
        public string birthMonth { get; set; }
        [Required]
        public string birthYear { get; set; }

        // Second part:

        [Required]
        public string email { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Password must consist of a minimum of 8 symbols", MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Password must consist of a minimum of 8 symbols", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Password fields do not match")]
        public string confirmPassword { get; set; }
        public Registration()
        {
            birthDay = "";
            birthMonth = "";
            birthYear = "";
            firstName = "";
            lastName = "";
            gender = true;

            email = "";
            password = "";
            confirmPassword = "";
        }
    }
}
