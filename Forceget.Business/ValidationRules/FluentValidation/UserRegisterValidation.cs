﻿using Forceget.Entities.Dtos;
using FluentValidation;

namespace Forceget.Business.ValidationRules.FluentValidation
{
    public class UserRegisterValidation : AbstractValidator<UserForRegisterDto>
    {
        public UserRegisterValidation()
        {
            RuleFor(u => u.Email).EmailAddress().WithMessage("Lütfen Geçerli Bir Email Adresi Giriniz!");
            RuleFor(u => u.FirstName).MinimumLength(3).WithMessage("Ad Alanı Minimum 3 Karakter Olmalı!");
            RuleFor(u => u.LastName).MinimumLength(3).WithMessage("Soyad Alanı Minimum 3 Karakter Olmalı!");
            RuleFor(u => u.Password).MinimumLength(3).WithMessage("Şifre Alanı Minimum 3 Karakter Olmalı!");
        }
    }
}
