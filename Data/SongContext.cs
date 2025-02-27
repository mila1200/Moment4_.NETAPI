using Moment4Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Moment4Api.Data;

//Context för anslutning
public class SongContext : DbContext
{
    public SongContext(DbContextOptions<SongContext> options) : base(options)
    {

    }

//referens till modellen
    public DbSet<SongModel> Songs { get; set; }
}
