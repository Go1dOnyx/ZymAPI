namespace ZymAPI.Models
{
    public class PaymentModel
    {
        //This Model might not be needed with Stripe API
        //Expiration Date will need an update to be only month/year
        public int Payment_ID { get; set; }
        public int User_ID { get; set; }
        public string Cardholder_Name { get; set; } = string.Empty;
        public string CardNum_Hash { get; set; } = string.Empty;
        public string Sec_Hash { get; set;} = string.Empty;
        public string Expiration_Date { get; set; } = string.Empty;
        public string CardType { get; set; } = string.Empty;    
    }
}
