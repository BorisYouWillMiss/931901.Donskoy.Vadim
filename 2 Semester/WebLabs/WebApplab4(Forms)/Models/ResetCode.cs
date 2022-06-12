namespace WebApplab4_Forms_.Models
{
    using System.ComponentModel.DataAnnotations;
    public class ResetCode
    {
        [Required]
        public string code { get; set; }
        public ResetCode()
        {
            code = "";
        }
    }
}
