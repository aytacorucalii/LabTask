using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademymanagementLabTask.Helpers;

public static class SqlHelper
{
    private readonly static string _connectionString = @"Server=localhost;Database=AB205AcademyDB;Trusted_Connection=True;TrustServerCertificate=True";
    public static string GetConnectionString()
    {
        return _connectionString;
    }
}
