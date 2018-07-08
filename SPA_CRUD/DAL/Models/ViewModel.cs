using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_CRUD.DAL.Models
{
    public class ViewModel
    {
        public List<User> Users { get; set; }
        public List<Department> Departments { get; set; }
    }
}