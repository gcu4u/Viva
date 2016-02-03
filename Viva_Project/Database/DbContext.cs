using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Viva_Project.Models;

namespace Viva_Project.Database
{
    public class DBContext : DbContext
    {
        public DBContext()
        { }

        public DbSet<UserModel> users { get; set; }
    }
}