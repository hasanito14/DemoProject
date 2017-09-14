using DAL;

namespace BLL
{
    public class BaseBll
    {
        protected RoleDb ObjDb;

        public BaseBll()
        {
            ObjDb = new RoleDb();



        }
    }
}
