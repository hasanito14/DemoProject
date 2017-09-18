namespace Dreamer.HR

{
    public class DALBase
    {
        protected HRdbContext db;

        public DALBase()
        {
            db = new HRdbContext();
        }
    }
}
