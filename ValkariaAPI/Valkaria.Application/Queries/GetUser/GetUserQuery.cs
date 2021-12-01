using MediatR;
using System;
namespace Valkaria.Application.Queries.GetUser
{
    public class GetUserQuery : IRequest<GetUserViewModel>
    {
        public GetUserQuery(int idUser)
        {
            IdUser = idUser;
        }

        public int IdUser { get; private set; }
    }
}
