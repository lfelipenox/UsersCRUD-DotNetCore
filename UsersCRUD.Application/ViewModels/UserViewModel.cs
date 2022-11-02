using System;
using System.Collections.Generic;
using System.Text;

namespace UsersCRUD.Application.ViewModels
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
