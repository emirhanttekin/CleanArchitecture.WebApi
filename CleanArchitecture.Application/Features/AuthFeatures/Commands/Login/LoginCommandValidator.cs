using FluentValidation;

namespace CleanArchitecture.Application.Features.AuthFeatures.Commands.Login;

public sealed class LoginCommandValidator : AbstractValidator<LoginCommand>
{
    public LoginCommandValidator()
    {
        RuleFor(p => p.UserNameOrEmail).NotEmpty().WithMessage("Kullandı adı yada mail bilgisi boş olamaz !");
        RuleFor(p => p.UserNameOrEmail).NotNull().WithMessage("ullandı adı yada mail bilgisi boş olamaz !");
        RuleFor(p => p.UserNameOrEmail).MinimumLength(3).WithMessage("Kullancı adı ve mail bilgisi en az 3 karakter olmalıdır");


        RuleFor(p => p.UserNameOrEmail).NotEmpty().WithMessage("Şifre boş olamaz !");
        RuleFor(p => p.UserNameOrEmail).NotNull().WithMessage("Şifre boş olamaz !");
        RuleFor(p => p.Password).Matches("[A-Z]").WithMessage("Şifre en az 1 adet büyük harf içermelidir");
        RuleFor(p => p.Password).Matches("[a-z]").WithMessage("Şifre en az 1 adet küçük harf içermelidir");
        RuleFor(p => p.Password).Matches("[0-9]").WithMessage("Şifre en az 1 adet rakam  içermelidir");
        RuleFor(p => p.Password).Matches("[^a-zA-Z0-9]").WithMessage("Şifre en az 1 adet özel karakter içermelidir");

    }
}
