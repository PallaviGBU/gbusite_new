using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace gbuweb.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Notice> Notices
        {
            get;
            set;
        }

        public DbSet<Recent> Recents
        {
            get;
            set;
        }
 public DbSet<Entity> Entities
        {
            get;
            set;
        }
        public DbSet<Program> Programs
        {
            get;
            set;
        }

        public MyDbContext()
            //Reference the name of your connection string ( WebAppCon )  
            : base("MyDbCon") { }
    }




}