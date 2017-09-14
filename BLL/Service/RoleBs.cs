using BOL;
using System.Collections.Generic;
using System.Threading.Tasks;
using BLL.Models;
using FluentValidation;

namespace BLL.Service
{
    public class RoleBs : BaseBll
    {

        public async Task<IList<Role>> GetAll()
        {

            return await ObjDb.GetALL();
        }
        public Role GetById(int Id)
        {
            return ObjDb.GetById(Id);
        }
        public async Task<bool> Insert(RoleAddModel model)
        {
            var validator = new RoleAddModelValidator();
            await validator.ValidateAndThrowAsync(model).ConfigureAwait(false);

            var data = new Role
            {
                RoleName = model.RoleName,
                RoleCode = model.RoleCode,
                RoleDescription = model.RoleDescription
            };

            ObjDb.RoleInsert(data);

            return true;
        }
        public void Delete(int Id)
        {
            ObjDb.RoleDelete(Id);
        }
        public void Update(Role role)
        {
            ObjDb.Update(role);
        }

    }
}
