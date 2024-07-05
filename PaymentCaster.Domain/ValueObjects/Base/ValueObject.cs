namespace PaymentCaster.Domain.ValueObjects.Base;

public abstract class ValueObject
{
    protected readonly ErrorMessages _messages = new ErrorMessages();
    public abstract void Validate();

}