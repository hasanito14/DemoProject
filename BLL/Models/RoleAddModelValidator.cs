using FluentValidation;

namespace BLL.Models
{
    public class RoleAddModelValidator: AbstractValidator<RoleAddModel>
    {
        public RoleAddModelValidator()
        {
            RuleFor(x => x.RoleName).NotEmpty();
            RuleFor(x => x.RoleCode).NotEmpty();
            RuleFor(x => x.RoleDescription).NotEmpty();
        }
    }
}
