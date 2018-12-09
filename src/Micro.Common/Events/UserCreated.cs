namespace Micro.Common.Events
{
    //User created class
    public class UserCreated : IEvent
    {
        public string Email { get; }

        public string Name { get; }

        protected UserCreated()
        {

        }

        public UserCreated(string email, string name)
        {
            Email = email;
            Name = name;
        }
    }
}