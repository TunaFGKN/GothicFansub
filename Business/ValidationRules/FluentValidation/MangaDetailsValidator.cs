using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class MangaDetailsValidator: AbstractValidator<MangaDetailsDto>
    {
        public MangaDetailsValidator()
        {
            RuleFor(md => md.MangaName).NotEmpty();
            RuleFor(md => md.MangakaName).NotEmpty();
            RuleFor(md => md.MangakaName).MinimumLength(2);
        }
    }
}
