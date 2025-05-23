﻿using MediatRPattern.MediatorStructure;

namespace MediatRPattern.ManagerStructure;

public abstract class Manager
{
    protected readonly AbstractMediator _mediator;

    public Manager(AbstractMediator mediator)
    {
        _mediator = mediator;
    }
}
