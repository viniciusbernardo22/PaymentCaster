﻿using PaymentCaster.Domain.ValueObjects;
using PaymentCaster.Shared.Entities;

namespace PaymentCaster.Domain.Entities;

public class Student : Entity
{
    private IList<Subscription> _subscriptions;
    
    public Student(Name name, Document document, Email email)
    {
        Name = name;
        Document = document;
        Email = email;
        _subscriptions = new List<Subscription>();
    }

    public Name Name { get; private set; }
    public Document Document { get; private set; }
    public Email Email { get; private set; }
    
    public Address? Address { get; private set; }

    public IReadOnlyCollection<Subscription> Subscriptions
    {
        get => _subscriptions.ToArray();
    }

    public void AddSubscription(Subscription sub)
    {
        foreach (Subscription subs in Subscriptions)
        {
            subs.Deactivate();
        }
        _subscriptions.Add(sub);
    }
}