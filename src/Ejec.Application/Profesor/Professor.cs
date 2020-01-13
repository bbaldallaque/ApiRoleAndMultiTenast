using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejec
{
   public  class Professor : FullAuditedEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long Age { get; set; }

        public bool HaveChlindres { get; set; }

        public bool IsPreffesional { get; set; }

        public string Address { get; set; }

    }
}
