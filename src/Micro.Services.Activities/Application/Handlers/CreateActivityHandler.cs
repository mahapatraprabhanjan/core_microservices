using System;
using System.Threading.Tasks;
using Micro.Common.Commands;
using Micro.Common.Events;
using RawRabbit;

namespace Micro.Services.Activities.Application.Handlers
{
    public class CreateActivityHandler : ICommandHandler<CreateActivity>
    {
        private readonly IBusClient _busClient;

        public CreateActivityHandler(IBusClient busClient)
        {
            _busClient = busClient;
        }

        public async Task HandleAsync(CreateActivity command)
        {
            Console.WriteLine($"Creating activity: {command.Name}");
            await _busClient.PublishAsync(new ActivityCreated(command.Id,
            command.UserId, command.Category, command.Name, command.Description, 
            command.CreatedAt));
        }
    }
}