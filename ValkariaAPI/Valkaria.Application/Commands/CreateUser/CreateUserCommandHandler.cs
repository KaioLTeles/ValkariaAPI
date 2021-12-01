using MediatR;
using Valkaria.Core.Entities;

namespace Valkaria.Application.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserViewModel>
    {
        public Task<CreateUserViewModel> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User(request.Name, request.Email, request.BirthDate);

            return Task.FromResult(new CreateUserViewModel(user.Id, user.Name, user.Email, user.BirthDate));
        }
    }
}
