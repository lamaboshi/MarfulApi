using Microsoft.EntityFrameworkCore;

namespace MarfulApi.Data
{
    public class MarfulDbContext:DbContext
    {
        public MarfulDbContext(DbContextOptions<MarfulDbContext> options) : base(options) { }
    }
}
