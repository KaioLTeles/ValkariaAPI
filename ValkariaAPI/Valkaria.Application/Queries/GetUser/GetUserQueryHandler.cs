using MediatR;

namespace Valkaria.Application.Queries.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, GetUserViewModel>
    {
        public Task<GetUserViewModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new GetUserViewModel(1, "Test", new List<PartyViewModel>()));
        }
    }
}
