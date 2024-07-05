using PaymentCaster.Domain.ValueObjects;
using Document = System.Reflection.Metadata.Document;

namespace PaymentCaster.Domain.Entities;

public class PayPalPayment : Payment
{
    public PayPalPayment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Address address, Email email, string transactionCode) : base(paidDate, expireDate, total, totalPaid, payer, document, address, email)
    {
        TransactionCode = transactionCode;
    }

    public string TransactionCode { get; private set; }
}