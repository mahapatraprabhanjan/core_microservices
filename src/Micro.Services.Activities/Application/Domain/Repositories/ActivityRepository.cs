using System;
using System.Threading.Tasks;
using Micro.Services.Activities.Application.Domain.Models;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Micro.Services.Activities.Application.Domain.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly IMongoDatabase _database;

        public ActivityRepository(IMongoDatabase database)
        {
            _database = database;
        }

        public async Task AddAsync(Activity activity) 
            => await Collection
            .InsertOneAsync(activity);

        public async Task<Activity> GetAsync(Guid Id)
            => await Collection
            .AsQueryable()
            .FirstOrDefaultAsync(predicate: x => x.Id == Id);

        private IMongoCollection<Activity> Collection
            => _database.GetCollection<Activity>("Activities");
    }
}