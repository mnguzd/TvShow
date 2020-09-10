using FilmsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmsApp.Data
{
    public class TvShowsContext : DbContext
    {
        public TvShowsContext(DbContextOptions<TvShowsContext> options)
            : base(options)
        {
        }

        public DbSet<TvShow> TvShow { get; set; }
    }
}
