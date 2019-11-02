using MediatR;
using Persistence.Entities;

namespace Transporter.Application.User.Query
{
    public class GetInvoicesRequest : IRequest<Invoice>
    {
        public int Id { get; set; }

        public GetInvoicesRequest(int id)
        {
            Id = id;
        }
    }
}
