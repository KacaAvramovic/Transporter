using MediatR;
using Persistence;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Transporter.Application.User.Query
{

    public class GetUsersRequestHandler : IRequestHandler<GetUsersRequest, Persistence.Entities.User>
    {
        private readonly TransporterContext _context;


        public GetUsersRequestHandler(TransporterContext context)
        {
            _context = context;
        }

        public async Task<Persistence.Entities.User> Handle(GetUsersRequest request, CancellationToken cancellationToken)
        {
            var user = _context.Users.First(u => u.Id == request.Id);
            
            return await Task.FromResult(user);
        }

    }
}