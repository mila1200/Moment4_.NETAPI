using Moment4Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Moment4Api.Data;

public class SongContext : DbContext
{
    public SongContext(DbContextOptions<SongContext> options) : base(options)
    {

    }

    public DbSet<SongModel> Songs { get; set; }
}
