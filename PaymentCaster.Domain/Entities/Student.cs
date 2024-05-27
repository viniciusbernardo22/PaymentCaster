﻿namespace PaymentCaster.Domain.Entities;

public class Student
{
    public Student(string firstName, string lastName, string document, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Document = document;
        Email = email;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Document { get; set; }
    public string Email { get; set; }
    public Address? Address { get; set; }
    public List<Subscription> Subscriptions { get; set; } = new();
}