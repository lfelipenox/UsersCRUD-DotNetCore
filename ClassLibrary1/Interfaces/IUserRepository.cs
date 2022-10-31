using System;
using System.Collections.Generic;
using System.Text;
using UsersCRUD.Domain.Entities;

namespace Template.Domain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetAll();
    }
}