namespace WebAppLab3_Quiz_.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Answer
    {

        [Required(ErrorMessage = ("Answer field is empty"))]
        public int answer { get; set; }
    }
}
