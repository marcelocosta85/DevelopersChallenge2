using Desafio.Nibo.Business.Interfaces;
using Desafio.Nibo.Business.Models;
using Desafio.Nibo.Business.Notifications;
using FluentValidation;
using FluentValidation.Results;

namespace Desafio.Nibo.Business.Services
{
    public abstract class BaseService
    {
        private readonly INotifier _notifier;

        protected BaseService(INotifier notifier)
        {
            _notifier = notifier;
        }

        protected void Notify(ValidationResult validationResult)
        {
            foreach(var error in validationResult.Errors)
            {
                Notify(error.ErrorMessage);
            }
        }

        protected void Notify(string message)
        {
            _notifier.Handle(new Notification(message));
        }

        protected bool ExecuteValidation<TV, TE>(TV validation, TE entiy) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validator = validation.Validate(entiy);

            if (validator.IsValid) return true;

            Notify(validator);

            return false;
        }
    }
}
