using Microsoft.EntityFrameworkCore;
using SoccerFieldServer.Core.Entities;

namespace SoccerFieldServer.Infrastructure.Data
{
    public class SoccerFieldServerContext : DbContext
    {
        public SoccerFieldServerContext(DbContextOptions<SoccerFieldServerContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<DetailsOfBookField>().HasKey(table => new {
                table.BookFieldId,
                table.ProductId
            });
            builder.Entity<CustomerHistory>().HasKey(table => new {
                table.CustomerId,
                table.BookFieldId
            });
            builder.Entity<WorkScheduleStaff>().HasKey(table => new {
                table.StaffId,
                table.Day,
                table.Shift
            });
        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<AdminWebsite> AdminWebsites { get; set; }
        public DbSet<GroupSoccerField> GroupSoccerFields { get; set; }
        public DbSet<SoccerField> SoccerFields { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<WorkScheduleStaff> WorkScheduleStaffs { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<BookField> BookFields { get; set; }        
        public DbSet<DetailsOfBookField> DetailsOfBookFields { get; set; }
        public DbSet<CustomerHistory> CustomerHistorys { get; set; }
    }

}
