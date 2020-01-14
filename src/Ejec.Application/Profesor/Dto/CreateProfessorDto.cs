using Abp.AutoMapper;
using Abp.Runtime.Validation;
using Ejec.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejec.Profesor.Dto
{

    [AutoMapTo(typeof(Professor))]
    public class CreateProfessorDto : IShouldNormalize
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long Age { get; set; }

        public bool HaveChlindres { get; set; }

        public bool IsPreffesional { get; set; }

        public string Address { get; set; }

        public string[] RoleNames { get; set; }

        public void Normalize()
        {
            if (RoleNames == null)
            {
                RoleNames = new string[0];
            }
        }
    }
}
