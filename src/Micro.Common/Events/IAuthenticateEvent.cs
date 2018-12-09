using System;

namespace Micro.Common.Events
{
    public interface IAuthenticateEvent:IEvent
    {
        Guid UserId { get; }        
    }
}