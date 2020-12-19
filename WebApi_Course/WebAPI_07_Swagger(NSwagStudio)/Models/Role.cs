using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_07_Swagger.Models
{
    public partial class Role : IEntity
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public short RoleId { get; set; }
        public string RoleDesc { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public int Id
        {
            get
            {
                return RoleId;
            }
        }
    }
}
