using BOL;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DAL
{
    public class RoleDb: DALBase
    {

        public  IList<Role> GetALL()
        {
           return db.Roles.ToList();
        }

        public Role GetById(int Id)
        {
            return db.Roles.Find(Id);
        }

        public void RoleInsert(Role role)
        {
            db.Roles.Add(role);

            Save();
        }

        public void RoleDelete(int Id)
        {
            Role role = db.Roles.Find(Id);
            db.Roles.Remove(role);
            Save();
        }

        public void Update(Role role)
        {
            db.Entry(role).State = EntityState.Modified;
            db.Configuration.ValidateOnSaveEnabled = false;
            Save();
            db.Configuration.ValidateOnSaveEnabled = true;
        }

        public void Save()
        {
            db.SaveChangesAsync();
        }
    }
}
