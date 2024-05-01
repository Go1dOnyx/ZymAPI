namespace Account.Microservice
{
    public class AdminModel
    {
        public int Admin_ID { get; set; }
        public string Admin_UserName { get; set; } = string.Empty;
        public string Admin_Email { get; set; } = string.Empty;
        public string Admin_Password_Hash { get; set;} = string.Empty;
        public bool Admin_Role { get; set; }
    }
}
