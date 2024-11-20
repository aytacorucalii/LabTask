using AcademymanagementLabTask.Helpers;
using AcademymanagementLabTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademymanagementLabTask.Contexts;

public class AcademyManagementDbContexts : DbContext
{ public DbSet<Student> students { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(SqlHelper.GetConnectionString());
        base.OnConfiguring(optionsBuilder);
    }
}
