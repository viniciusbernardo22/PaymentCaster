using System.ComponentModel.DataAnnotations;
using PaymentCaster.Domain.Enums;
using PaymentCaster.Domain.ValueObjects.Base;

namespace PaymentCaster.Domain.ValueObjects;

public class Document : ValueObject
{
    public string Number { get; set; }
    public EDocumentType Type { get; set; }
    
    public Document(string number, EDocumentType type)
    {
        Number = number;
        Type = type;
        Validate();
    }
    
    public sealed override void Validate()
    {
        if (Number.Length is not 14)
            throw new ValidationException(_messages.InvalidFormat(nameof(Number)));
    }
}