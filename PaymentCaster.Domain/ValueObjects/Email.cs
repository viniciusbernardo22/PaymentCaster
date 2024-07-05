using System.Text.RegularExpressions;
using PaymentCaster.Domain.ValueObjects.Base;

namespace PaymentCaster.Domain.ValueObjects;

public class Email : ValueObject
{
    public Email(string address)
    {
        Address = address;

        Validate();
    }

    public string Address { get; set; }
    
    
    public override void Validate()
    {
        
    }
}