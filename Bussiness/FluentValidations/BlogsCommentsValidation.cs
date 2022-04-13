using Entities.DtoTable;
using FluentValidation;

namespace Bussiness.FluentValidations
{
    public class BlogsCommentsValidation : AbstractValidator<DtoBlogsComments>
    {
        public BlogsCommentsValidation()
        {
            RuleFor(x => x.Commenter).MaximumLength(50).WithMessage("Max 50 Karakter");
            RuleFor(x => x.Commenter).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.Comment).MaximumLength(350).WithMessage("Max 350 Karakter");
            RuleFor(x => x.Comment).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.Email).MaximumLength(50).WithMessage("Max 50 Karakter");
        }
    
    }
}
