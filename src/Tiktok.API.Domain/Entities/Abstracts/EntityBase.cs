﻿using Tiktok.API.Domain.Entities.Interfaces;

namespace Tiktok.API.Domain.Entities.Abstracts;

public abstract class EntityBase<T> : IEntityBase<T>
{
    public T Id { get; set; }
}