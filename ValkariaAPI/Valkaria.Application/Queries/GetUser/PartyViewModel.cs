using Valkaria.Core.Enums;

namespace Valkaria.Application.Queries.GetUser
{
    public class PartyViewModel
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public PartyUserRoleEnum RoleUser { get; private set; }
    }
}
