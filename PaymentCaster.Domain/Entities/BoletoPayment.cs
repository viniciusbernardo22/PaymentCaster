namespace PaymentCaster.Domain.Entities;

public class BoletoPayment : Payment
{
    public BoletoPayment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, string document, Address address, string email, string barCode, string boletoNumber) : base(paidDate, expireDate, total, totalPaid, payer, document, address, email)
    {
        BarCode = barCode;
        BoletoNumber = boletoNumber;
    }

    public string BarCode { get; set; }
    public string BoletoNumber { get; set; }

}