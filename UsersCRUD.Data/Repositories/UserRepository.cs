using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersCRUD.Data.Repositories;
using UsersCRUD.Domain.Interfaces;
using UsersCRUD.Data.Context;
using UsersCRUD.Domain.Entities;

namespace UsersCRUD.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(UsersCRUDContext context)
            : base(context) { }

        public IEnumerable<User> GetAll()
        {
            return Query(x => !x.IsDeleted);
        }
        
    }
}
