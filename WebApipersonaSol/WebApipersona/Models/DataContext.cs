namespace WebApipersona.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<WebApipersona.Models.Person> People { get; set; }
    }
}