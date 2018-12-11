using System;
using System.Threading.Tasks;
using Micro.Common.Events;

namespace Micro.Api.Application.Handlers
{
    public class ActivityCreatedHandler : IEventHandler<ActivityCreated>
    {
        public async Task HandleAsync(ActivityCreated @event)
        {
            await Task.CompletedTask;
            Console.WriteLine($"Activity created:{@event.Name}");
        }
    }
}