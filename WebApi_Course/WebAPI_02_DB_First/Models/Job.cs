using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_02_DB_First.Models
{
    public partial class Job
    {
        public Job()
        {
            Users = new HashSet<User>();
        }

        public short JobId { get; set; }
        public string JobDesc { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
