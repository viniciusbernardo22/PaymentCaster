using System.ComponentModel.DataAnnotations;
using PaymentCaster.Domain.ValueObjects.Base;

namespace PaymentCaster.Domain.ValueObjects;

public class Name : ValueObject
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public Name(string firstName,string lastName )
    {
        FirstName = firstName;
        LastName = lastName;
        Validate();
    }

    public sealed override void Validate()
    {
        if (string.IsNullOrEmpty(FirstName))
            throw new ValidationException(_messages.EmptyOrNullMessage(nameof(FirstName)));
    }
}