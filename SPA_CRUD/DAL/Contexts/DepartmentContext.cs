using SPA_CRUD.DAL.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SPA_CRUD.DAL.Contexts
{
    public class DepartmentContext:DbContext
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["departmentConnection"].ConnectionString;
        public DepartmentContext():base(connectionString)
        {
         
        }

        public DbSet<Department> Departments { get; set; }
    }
}