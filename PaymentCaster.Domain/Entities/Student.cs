namespace PaymentCaster.Domain.Entities;

public class Student
{
    public Student()
    {
        Subscriptions = new List<Subscription>();
        Addresses = new List<Address>();
    }
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Document { get; set; }
    public string Email { get; set; }
    public List<Address> Addresses { get; set; }
    public List<Subscription> Subscriptions { get; set; }
}