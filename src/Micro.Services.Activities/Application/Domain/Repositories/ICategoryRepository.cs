using System.Collections.Generic;
using System.Threading.Tasks;
using Micro.Services.Activities.Application.Domain.Models;

namespace Micro.Services.Activities.Application.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task<Category> GetAsync(string name);

        Task<IEnumerable<Category>> GetAllAsync();

        Task AddAsync(Category category);
    }
}