using Carsties.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Carsties.Data.Context
{
    public class CarstiesDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Auction> Auctions { get; set; }
       
    }
}
