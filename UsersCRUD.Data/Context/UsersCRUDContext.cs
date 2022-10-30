using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersCRUD.Data.Exensions;
using UsersCRUD.Data.Mappings;
using UsersCRUD.Domain.Entities;

namespace UsersCRUD.Data.Context
{
    public class UsersCRUDContext : DbContext
    {
        public UsersCRUDContext(DbContextOptions<UsersCRUDContext> option)
            : base(option) { }

        #region DBSets

        public DbSet<User> Users { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());

            modelBuilder.SeedData();

            base.OnModelCreating(modelBuilder);
        }


    }
}
