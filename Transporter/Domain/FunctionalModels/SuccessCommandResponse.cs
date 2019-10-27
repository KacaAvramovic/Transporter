using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transporter.Domain.Enums;
using Transporter.Domain.Interfaces.Core;

namespace Transporter.Domain.FunctionalModels
{
    public class SuccessCommandResponse : ICommandResponse
    {
        public EventStatus Status { get; } = EventStatus.Success;
        public string Message { get; set; }
        public object Response { get; set; }
    }
}
