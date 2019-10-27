using FluentValidation.Validators;
using MediatR;
using System;

namespace Transporter
{
    public static class MediatorExtensions
    {
        public static void NotFound<T>(IRequest<T> request, PropertyValidatorContext context)
        {
            throw new Exception($"Value not found of type \"{nameof(context.PropertyName)}\".");
        }

        public static void NotFound(IRequest request, PropertyValidatorContext context)
        {
            throw new Exception($"Value not found of type \"{nameof(context.PropertyName)}\".");
        }
    }
}
