using System;
using System.Collections.Generic;
using System.Text;
using UsersCRUD.Application.ViewModels;

namespace UsersCRUD.Application.Interfaces
{
    public interface IUserService
    {
        List<UserViewModel> Get();

        bool Post(UserViewModel userViewModel);
    }
}
