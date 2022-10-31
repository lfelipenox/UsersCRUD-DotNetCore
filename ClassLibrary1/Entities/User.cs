using System;
using System.Collections.Generic;
using System.Text;
using UsersCRUD.Domain.Models;

namespace UsersCRUD.Domain.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
