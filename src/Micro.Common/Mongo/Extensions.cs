using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Micro.Common.Mongo
{
    public static class Extensions
    {
        public static void AddMongoDB(this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.Configure<MongoOptions>(configuration.GetSection("Mongo"));
            services.AddSingleton<MongoClient>(c => 
            {
                var options = c.GetService<IOptions<MongoOptions>>();
                return new MongoClient(options.Value.ConnectionString);
            });

            services.AddTransient<IMongoDatabase>(c => 
            {
                var options = c.GetService<IOptions<MongoOptions>>();
                var client = c.GetService<MongoClient>();

                return client.GetDatabase(options.Value.Database);
            });

            services.AddTransient<IDatabaseInitializer, MongoInitializer>();
            services.AddTransient<IDatabaseSeeder, MongoSeeder>();
        }
    }
}