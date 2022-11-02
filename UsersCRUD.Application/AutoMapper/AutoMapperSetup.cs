using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using UsersCRUD.Application.ViewModels;
using UsersCRUD.Domain.Entities;

namespace UsersCRUD.Application.AutoMapper
{
    public class AutoMapperSetup: Profile
    {
        public AutoMapperSetup()
        {
            #region ViewModelToDomain

            CreateMap<UserViewModel, User>();

            #endregion

            #region DomainToViewModel

            CreateMap<User, UserViewModel>();

            #endregion


        }


    }
}
