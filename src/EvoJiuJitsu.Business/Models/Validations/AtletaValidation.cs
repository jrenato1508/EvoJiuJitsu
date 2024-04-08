using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoJiuJitsu.Business.Models.Validations
{
    public class AtletaValidation : AbstractValidator<Atleta>
    {
        public AtletaValidation()
        {
            RuleFor(a => a.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 100)
                .WithMessage("o campo {PropetyName} precisa ter entre {MinLength} e {MaxLenght} caracteres");

            RuleFor(a => a.Idade)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(a => a.Peso)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(a => a.Cpf)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(11, 11)
                .WithMessage("O campo {PropertyName} precisa ter {MaxLength} caracteres");

            RuleFor(a => a.Telefone)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")

                .WithMessage("O campo {PropertyName} precisa ter {MaxLength} caracteres");

            RuleFor(a => a.Sexo)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(a => a.DataNascimento)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(a => a.Faixa)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(a => a.Polo)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");

        }
    }
}
