using Transporter.Domain.Enums;
using Transporter.Domain.Interfaces.Core;

namespace Transporter.Domain.FunctionalModels
{
    public class ErrorCommandResponse : ICommandResponse
    {
        public EventStatus Status { get; } = EventStatus.Error;
        public string Message { get; set; }
        public object Response { get; set; }
   }
}
