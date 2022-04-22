using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_web_api.Context
{
    using Microsoft.EntityFrameworkCore;

    public class CompanyContext
        : DbContext
    {
        public CompanyContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Models.Employee> Employees { get; set; }
    }
}
