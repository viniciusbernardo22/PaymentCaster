using PaymentCaster.Domain.Entities;

namespace PaymentCaster.Tests.Entities;

[TestClass]
public class StudentTests
{
    [TestMethod]
    
    public void TestMethod1()
    {
        var student = new Student("Vinícius", "Bernardo", "9999999999-1", "vini383@gmail.com");
        
    }
}