using MediatR;


namespace Transporter.Application.User.Query
{
    public class GetUsersRequest : IRequest<Persistence.Entities.User>
    {
        public int Id { get; set; }
    }
}
