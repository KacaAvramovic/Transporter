using MediatR;
using Persistence;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Transporter.Application.User.Query
{

    public class GetInvoicesRequestHandler : IRequestHandler<GetInvoicesRequest, Persistence.Entities.Invoice>
    {
        private readonly TransporterContext _context;


        public GetInvoicesRequestHandler(TransporterContext context)
        {
            _context = context;
        }

        public async Task<Persistence.Entities.Invoice> Handle(GetInvoicesRequest request, CancellationToken cancellationToken)
        {
            var invoice = _context.Invoices.First(u => u.Id == request.Id);
            
            return await Task.FromResult(invoice);
        }

    }
}