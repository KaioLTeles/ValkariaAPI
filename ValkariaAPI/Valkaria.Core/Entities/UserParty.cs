using Valkaria.Core.Enums;

namespace Valkaria.Core.Entities
{
    public class UserParty : BaseEntity
    {
        public UserParty(int idUser, int idParty, PartyUserRoleEnum userRole)
        {
            IdUser = idUser;
            IdParty = idParty;
            UserRole = userRole;
            CreatedAt = DateTime.Now;
        }

        public int IdUser { get; private set; }
        public int IdParty { get; private set; }
        public PartyUserRoleEnum UserRole { get; set; }
    }
}
