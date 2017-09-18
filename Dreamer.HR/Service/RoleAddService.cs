using Dreamer.HR.Models;
using FluentValidation;
using System;
using System.Threading.Tasks;

namespace Dreamer.HR.Service
{
    public class RoleAddService
    {
        private readonly HRdbContext _context;

        public RoleAddService() : this(new HRdbContext())
        {
        }

        public RoleAddService(HRdbContext context)
        {

            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<RoleAddServiceResult> Execute(RoleAddModel model)
        {
            var validator = new RoleAddModelValidator(_context);

            await validator.ValidateAndThrowAsync(model).ConfigureAwait(false);

            var data = new Role
            {
                RoleCode = model.RoleCode,
                RoleName = model.RoleName,
                RoleDescription = model.RoleDescription
            };
            data.RoleId = Guid.NewGuid();

            data.LastModifiedBy = data.CreatedBy;
            data.LastModifiedDate = DateTime.UtcNow;
            data.IsDeleted = false;
            data.CreatedDate = DateTime.UtcNow;

            _context.Roles.Add(data);

            var result = new RoleAddServiceResult();

            await _context.SaveChangesAsync();

            result.Id = data.RoleId;
            return result;
        }
    }
}
