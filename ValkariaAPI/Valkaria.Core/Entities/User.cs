namespace Valkaria.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            CreatedAt = DateTime.Now;
            Parties = new List<Party>();
            Active = true;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }        
        public List<Party> Parties { get; private set; }
        public bool Active { get; private set; }

    }
}
