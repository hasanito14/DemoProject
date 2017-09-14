using BOL;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL
{
    public class RoleBs
    {
        private RoleDb objDb;

        public RoleBs()
        {
            objDb = new RoleDb();



        }
        public IList<Role> GetALL()
        {
            return objDb.GetALL();
        }
        public Role GetByID(int Id)
        {
            return objDb.GetById(Id);
        }
        public bool Insert(Role role)
        {
            objDb.RoleInsert(role);
            return true;
        }
        public void Delete(int Id)
        {
            objDb.RoleDelete(Id);
        }
        public void Update(Role role)
        {
            objDb.Update(role);
        }

    }
}
