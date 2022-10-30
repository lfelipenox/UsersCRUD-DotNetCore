using System;
using System.Collections.Generic;
using System.Text;

namespace UsersCRUD.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
