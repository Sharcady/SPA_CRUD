using SPA_CRUD.DAL.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SPA_CRUD.DAL.Contexts
{
    public class UserContext: DbContext
    {
        
        private static string connectionString = ConfigurationManager.ConnectionStrings["userConnection"].ConnectionString;
        public UserContext():base(nameOrConnectionString: connectionString)
        {
            
        }       

        public DbSet<User> Users { get; set; }
    }
   
}