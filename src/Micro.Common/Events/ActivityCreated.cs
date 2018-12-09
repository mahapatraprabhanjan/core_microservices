using System;

namespace Micro.Common.Events
{
    public class ActivityCreated : IAuthenticateEvent
    {
        public Guid Id { get; private set; }

        public Guid UserId { get; }

        public string Category { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public DateTime CreatedAt { get; private set; }

        protected ActivityCreated()
        {

        }

        public ActivityCreated(Guid id, Guid userId, string category,
        string name, string description, DateTime createdAt)
        {
            Id = id;
            UserId = userId;
            Category = category;
            Name = name;
            Description = description;
            CreatedAt = createdAt;
        }
    }
}