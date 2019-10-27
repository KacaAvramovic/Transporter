using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Transporter
{

    public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly IValidatorFactory _validationFactory;

        public ValidationBehavior(IValidatorFactory validationFactory)
        {
            _validationFactory = validationFactory;
        }

        public async Task<TResponse> Handle(
            TRequest request,
            CancellationToken cancellationToken,
            RequestHandlerDelegate<TResponse> next)
        {
            var validator = _validationFactory.GetValidator(request.GetType());
            var result = validator?.Validate(request);

            if (result != null && !result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            var response = await next();

            return response;
        }

    }
}
