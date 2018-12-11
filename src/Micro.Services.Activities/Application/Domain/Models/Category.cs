using System;

namespace Micro.Services.Activities.Application.Domain.Models
{
    public class Category
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        protected Category()
        {
            
        }

        public Category(string name)
        {
            Id = Guid.NewGuid();
            Name = name.ToLowerInvariant();
        }
    }
}