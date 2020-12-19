using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI_08_RepoPattern.Models
{
    public partial class Job : IEntity
    {
        public short JobId { get; set; }
        public string JobDesc { get; set; }

        public int Id
        {
            get
            {
                return JobId;
            }
        }
    }
}
