﻿using AcexxII.API.Models;
using FluentValidation;

namespace AcexxII.API.Services
{
    public class UserValidator : AbstractValidator<UserPaciente>
    {

        public UserValidator()
        {
            RuleFor(user => user.NomeCompleto)
                .NotEmpty().WithMessage("O nome completo é obrigatório.")
                .Length(2, 100).WithMessage("O nome completo deve ter entre 2 e 100 caracteres.");

            RuleFor(user => user.Email)
                .NotEmpty().WithMessage("O e-mail é obrigatório.")
                .EmailAddress().WithMessage("O e-mail deve estar em um formato válido.");

            RuleFor(user => user.Senha)
                .NotEmpty().WithMessage("A senha é obrigatória.")
                .MinimumLength(6).WithMessage("A senha deve ter pelo menos 6 caracteres.");

            RuleFor(user => user.ConfirmaSenha)
                .Equal(user => user.Senha).WithMessage("A confirmação da senha deve corresponder à senha.");
        }

    }
}
