using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersCRUD.Domain.Entities;

namespace UsersCRUD.Data.Exensions
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                    new User { Id = Guid.Parse("682cf4a8-396f-4c1b-a79d-86b4263b252e"), Name = "User Default", Email = "userdefault@usercrud.com", DateCreated = new DateTime(2022, 2, 2), IsDeleted = false, DateUpdated = null }
                );            

            return builder;
        }
    }
}
