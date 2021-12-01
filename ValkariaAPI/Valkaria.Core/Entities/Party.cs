namespace Valkaria.Core.Entities
{
    public class Party : BaseEntity
    {
        public Party(string title, string description)
        {
            Title = title;
            Description = description;
            CreatedAt = DateTime.Now;
            PartyMembers = new List<User>();
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public List<User> PartyMembers { get; private set; }
    }
}
