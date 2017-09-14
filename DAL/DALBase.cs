namespace DAL
{
    public class DALBase
    {
        protected DTPdbContext db;

        public DALBase()
        {
            db = new DTPdbContext();
        }
    }
}
