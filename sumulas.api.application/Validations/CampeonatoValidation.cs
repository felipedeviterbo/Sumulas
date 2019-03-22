using FluentValidation;
using FluentValidation.Results;
using sumulas.api.application.ViewModel;
using System;

namespace sumulas.api.application.Validations
{
    public class CampeonatoValidation : AbstractValidator<CampeonatoModel>
    {
        public CampeonatoValidation()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("O campo Id deve ser informado");
            RuleFor(x => x.Name).NotEmpty().WithMessage("O campo deve ser informado");
            RuleFor(x => x.Year).LessThan(y => DateTime.Now.Date.AddYears(-100).Year).WithMessage("Ano inválido");
            //RuleFor(x => x.DataNascimento.Date).LessThan(p => DateTime.Now.Date.AddYears(-17)).WithMessage("Data de Nascimento menor que 18 anos");
            
        }
        public override FluentValidation.Results.ValidationResult Validate(ValidationContext<CampeonatoModel> context)
        {
            return context?.InstanceToValidate == null
                ? new FluentValidation.Results.ValidationResult(new[] { new ValidationFailure("Campeonatos", "Campeonato inválido para cadastro.") })
                : base.Validate(context);
        }

    }
}