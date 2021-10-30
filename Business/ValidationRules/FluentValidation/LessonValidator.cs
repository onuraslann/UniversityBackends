using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class LessonValidator:AbstractValidator<Lesson>
    {
        public LessonValidator()
        {
            RuleFor(l => l.Credit).LessThanOrEqualTo(10).WithMessage("Bir dersin kredisi en fazla 10 kredi olabilir");
        }
    }
}
