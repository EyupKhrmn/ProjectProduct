using EntityLayer.Entities;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class CategoryRules: AbstractValidator<Category>
    {
        public CategoryRules()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori adı boş geçilemez !");
            RuleFor(x => x.Name).MinimumLength(3).MaximumLength(30);
        }
    }
}