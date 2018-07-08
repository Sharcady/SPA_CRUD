using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_CRUD.DAL.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int DepartmentId { get; set; }
    }
}