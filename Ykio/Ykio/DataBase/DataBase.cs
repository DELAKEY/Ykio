using Microsoft.EntityFrameworkCore;

namespace Ykio.DataBase
{
    public class DataBase : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //delakey:xIUD4oP0Tln
            //10.16.13.68:5432
            //optionsBuilder.UseSqlite("Data Source=helloapp.db");
            //optionsBuilder.UseNpgsql("Host=10.16.13.68;Database=tgreposter;Username=delakey;Password=xIUD4oP0Tln");
        }

    }
}
