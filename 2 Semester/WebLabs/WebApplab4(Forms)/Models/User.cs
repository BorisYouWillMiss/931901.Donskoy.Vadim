namespace WebApplab4_Forms_.Models
{
    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string birthDay { get; set; }
        public bool gender { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int RegistrationStage { get; set; }
        public User()
        {
            firstName = "Not stated";
            lastName = "Not stated";
            birthDay = "Not stated";
            gender = true;
            email = "Not stated";
            password = "";
            RegistrationStage = 1;
        }

    }
}
