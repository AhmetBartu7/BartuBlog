using Entities.DtoTable;
using FluentValidation;

namespace Bussiness.FluentValidations
{
    public class MyAccountsValidation : AbstractValidator<DtoMyAccounts>
    {
        public MyAccountsValidation()
        {

            RuleFor(x => x.Linkedin).MaximumLength(50).WithMessage("Max 50 Karakter");
            RuleFor(x => x.Instagram).MaximumLength(50).WithMessage("Max 50 Karakter");
            RuleFor(x => x.Github).MaximumLength(50).WithMessage("Max 50 Karakter");
            RuleFor(x => x.Twitter).MaximumLength(50).WithMessage("Max 50 Karakter");
            RuleFor(x => x.CoverLetter).MaximumLength(150).WithMessage("Max 150 Karakter");
            RuleFor(x => x.Information).MaximumLength(150).WithMessage("Max 150 Karakter");
            RuleFor(x => x.Email).MaximumLength(150).WithMessage("Max 150 Karakter");
            RuleFor(x => x.NameSurname).MaximumLength(150).WithMessage("Max 150 Karakter");
            RuleFor(x => x.Password).MaximumLength(150).WithMessage("Max 150 Karakter");
            RuleFor(x => x.Images).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Boş Bırakılamaz");




        }
    }
}
