using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data;

namespace MVCHello.Models
{
    public class OurDBContext : DbContext
    {
        public DbSet<Members> memberAccount { get; set; }

    }

}