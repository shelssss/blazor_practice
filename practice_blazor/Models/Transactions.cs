namespace practice_blazor.Models
{
    public class Transactions
    {
        public Guid Id { get; set; }
        public string ClientName { get; set; }
        public string ClientAppoinment { get; set; }
        public DateOnly PaymentDate { get; set; }
        public double Payment { get; set; }
        public string PaymentMethod { get; set; }
    }
}
