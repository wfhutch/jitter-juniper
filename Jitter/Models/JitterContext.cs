using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Jitter.Models
{
    public class JitterContext : DbContext  // Have to be using System.Data.Entity to inherit from DbContext
    {
        // IDbSet, IQueryable
        public DbSet<JitterUser> JitterUsers { get; set; }  // Creates JitterUser table in the database.
        public DbSet<Jot> Jots { get; set; }  // Allows access to jots without going through user.

    }
}