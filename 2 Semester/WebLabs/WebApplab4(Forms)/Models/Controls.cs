namespace WebApplab4_Forms_.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Controls
    {
        [Required(ErrorMessage ="The form is empty")]
        public string textBox { get; set; }
        [Required(ErrorMessage = "The form is empty")]
        public string textArea { get; set; }
        [Required(ErrorMessage = "The form is empty")]
        public string checkBox { get; set; }
        [Required(ErrorMessage = "Choose the value")]
        public string radio { get; set; }
        [Required(ErrorMessage = "Choose the value")]
        public string dropDownList { get; set; }
        [Required(ErrorMessage = "Choose the value")]
        public string listBox { get; set; }

        public Controls()
        {
            textBox = "";
            textArea = "";
            checkBox = "";
            radio = "";
            dropDownList = "";
            listBox = "";
        }
    }
}
