using FluentValidation;

namespace Dreamer.HR.Models
{
    public class RoleAddModelValidator: AbstractValidator<RoleAddModel>
    {
        public RoleAddModelValidator(HRdbContext _context)
        {
            RuleFor(x => x.RoleName).NotEmpty();
            RuleFor(x => x.RoleCode).NotEmpty();
            RuleFor(x => x.RoleDescription).NotEmpty();
        }
    }
}
