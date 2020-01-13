using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejec.Profesor.Dto
{
    [AutoMap(typeof(Professor))]
    public class ProfessorDto : EntityDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long Age { get; set; }

        public bool HaveChlindres { get; set; }

        public bool IsPreffesional { get; set; }

        public string Address { get; set; }

    }
}
