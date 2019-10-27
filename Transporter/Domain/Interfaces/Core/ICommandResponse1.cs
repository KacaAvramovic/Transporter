using Transporter.Domain.Enums;

namespace Transporter.Domain.Interfaces.Core
{
    public interface ICommandResponse
    {
        EventStatus Status { get; }
        string Message { get; set; }
        object Response { get; set; }
    }
}
