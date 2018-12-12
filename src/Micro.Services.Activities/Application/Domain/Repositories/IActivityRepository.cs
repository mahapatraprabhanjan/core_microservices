using System;
using System.Threading.Tasks;
using Micro.Services.Activities.Application.Domain.Models;

namespace Micro.Services.Activities.Application.Domain.Repositories
{
    public interface IActivityRepository
    {
        Task<Activity> GetAsync(Guid Id);

        Task AddAsync(Activity activity);
    }
}