using Microsoft.EntityFrameworkCore;
using Univ_WebSite_Api_Core.Models;

namespace Univ_WebSite_Api_Core.Appcode
{
    public class UnivEntities :DbContext
    {
        public UnivEntities(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Person> Person { get; set; }
    }
}
