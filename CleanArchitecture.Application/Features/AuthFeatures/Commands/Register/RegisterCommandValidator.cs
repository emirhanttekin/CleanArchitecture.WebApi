﻿using FluentValidation;

namespace CleanArchitecture.Application.Features.AuthFeatures.Commands.Register;

public sealed class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
    public RegisterCommandValidator()
    {
        RuleFor(p => p.Email).NotEmpty().WithMessage("Mail bilgisi boş olamaz !");
        RuleFor(p => p.Email).NotNull().WithMessage("Mail bilgisi boş olamaz !");
        RuleFor(p => p.Email).EmailAddress().WithMessage("Geçerli bir mail adresi girin !");

        RuleFor(p => p.UserName).NotEmpty().WithMessage("Kullandı adı bilgisi boş olamaz !");
        RuleFor(p => p.UserName).NotNull().WithMessage("Kullanıcı adı bilgisi boş olamaz !");
        RuleFor(p => p.UserName).MinimumLength(3).WithMessage("Kullancı adı en az 3 karakter olmalıdır");


        RuleFor(p => p.Email).NotEmpty().WithMessage("Şifre boş olamaz !");
        RuleFor(p => p.Email).NotNull().WithMessage("Şifre boş olamaz !");
        RuleFor(p => p.Password).Matches("[A-Z]").WithMessage("Şifre en az 1 adet büyük harf içermelidir");
        RuleFor(p => p.Password).Matches("[a-z]").WithMessage("Şifre en az 1 adet küçük harf içermelidir");
        RuleFor(p => p.Password).Matches("[0-9]").WithMessage("Şifre en az 1 adet rakam  içermelidir");
        RuleFor(p => p.Password).Matches("[^a-zA-Z0-9]").WithMessage("Şifre en az 1 adet özel karakter içermelidir");


    }
}
