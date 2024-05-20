namespace PaymentCaster.Domain.Entities;

public class Address
{
    public string Street { get; set; }
    public string Number { get; set; }
    public string? Reference { get; set;}
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public GeoLocalization Location { get; set; }
   
}

public class GeoLocalization
{
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
}