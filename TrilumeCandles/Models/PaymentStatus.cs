namespace TrilumeCandles.Models
{
    public enum PaymentStatus
    {
        Pending = 0,
        Paid = 1,
        Failed = 2,
        Refunded = 3,
        Canceled = 4,
        PartiallyRefunded = 5,
        PartiallyPaid = 6,
        Authorized = 7,
        Voided = 8,
        Expired = 9,
        Declined = 10,
        Chargeback = 11
    }
}
