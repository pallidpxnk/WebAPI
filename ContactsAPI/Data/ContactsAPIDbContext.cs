using Microsoft.EntityFrameworkCore;
using ContactsAPI.Models;

namespace ContactsAPI.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Contact> Contacs { get; set; }
    }
}
