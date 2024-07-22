using FluentValidation;

namespace Vertical.Slice.Architecture.Features.SampleGet
{
    public class SampleGetRequestValidator : AbstractValidator<SampleGetRequest>
    {
        public SampleGetRequestValidator()
        {
            this.ClassLevelCascadeMode = CascadeMode.Stop;
            this.RuleLevelCascadeMode = CascadeMode.Stop;

            this.RuleFor(x => x.QueryParam1)
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} is invalid");

            this.RuleFor(x => x.QueryParam2)
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} is invalid");

            this.RuleFor(x => x.RouteParam1)
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} is invalid");

            this.RuleFor(x => x.RouteParam2)
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} is invalid");
        }
    }
}
