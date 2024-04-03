using EvoJiuJitsu.Business.Interfaces;
using EvoJiuJitsu.Business.Models;
using EvoJiuJitsu.Business.Notificacoes;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoJiuJitsu.Business.Services
{
    public abstract class BaseService
    {
        private readonly INotificador _notificador;
        public BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected bool ExecurarValidacao<TV, TE>(TV validacao, TE entitie) where TV : AbstractValidator<TE> where TE: Entity
        {
            var validator = validacao.Validate(entitie);
            if (validator.IsValid) return true;

            Notificar(validator);

            return false;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string mensagem)
        {
            _notificador.Handle(new Notificacao(mensagem));
        }
    }
}
