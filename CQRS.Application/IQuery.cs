﻿using MediatR;

namespace CQRS.Application
{
    public interface IQuery : IRequest
    {

    }

    public interface IQuery<out TResult> : IRequest<TResult>
    {

    }
}
