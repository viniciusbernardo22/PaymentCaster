﻿namespace PaymentCaster.Shared.Entities;

public abstract class Entity
{
    public Guid Id { get; private set; } = Guid.NewGuid();
}