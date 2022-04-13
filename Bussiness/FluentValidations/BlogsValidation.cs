using Entities.DtoTable;
using FluentValidation;

namespace Bussiness.FluentValidations
{
    public class BlogsValidation: AbstractValidator<DtoBlogs>
    {
        public BlogsValidation()
        {
            RuleFor(x=> x.BlogName).MaximumLength(50).WithMessage("Max 50 Karakter");
            RuleFor(x => x.BlogName).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.Explanation).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.Images).NotEmpty().WithMessage("Boş Bırakılamaz");
        }
    }
}
