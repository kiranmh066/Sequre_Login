using Microsoft.EntityFrameworkCore;
using OfficeSeatBookingEntity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSeatBookingDAL
{
    public class OfficeDbContext:DbContext
    {
        public OfficeDbContext()
        {
        }
        public OfficeDbContext(DbContextOptions<OfficeDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> tbl_Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=DESKTOP-7PNCAE8\\SQLEXPRESS; Initial Catalog = kiran2; Integrated Security=True;Trusted_Connection=True; TrustServerCertificate=True;");

        }
    }
}
