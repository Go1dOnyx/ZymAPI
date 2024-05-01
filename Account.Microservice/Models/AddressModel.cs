namespace Account.Microservice
{
    public class AddressModel
    {
        public int Addr_ID { get; set; }
        public int UserID { get; set; }
        public string Street { get; set; } = string.Empty;
        public string Apt { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public int ZipCode { get; set; }
        public string Country { get; set; } = string.Empty;
    }
}
