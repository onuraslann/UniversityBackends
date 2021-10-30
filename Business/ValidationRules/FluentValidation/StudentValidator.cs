using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
   public class StudentValidator:AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(s => s.Age).GreaterThanOrEqualTo(18);
            RuleFor(s => s.FirstName).MinimumLength(2);
            RuleFor(s => s.StudentNo).NotEmpty();
        }
    }
}
