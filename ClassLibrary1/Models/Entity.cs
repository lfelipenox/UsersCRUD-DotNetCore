using System;
using System.Collections.Generic;
using System.Text;

namespace UsersCRUD.Domain.Models
{
    public class Entity
    {
        public Guid Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }

        public Boolean IsDeleted { get; set; }
    }
}
