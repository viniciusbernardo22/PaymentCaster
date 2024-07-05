using PaymentCaster.Domain;

namespace PaymentCaster.Shared.ValueObjects;

public abstract class ValueObject
{
    protected readonly ErrorMessages _messages = new ErrorMessages();
    public abstract void Validate();

}