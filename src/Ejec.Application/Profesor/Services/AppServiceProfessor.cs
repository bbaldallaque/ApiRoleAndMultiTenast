using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Ejec.Authorization;
using Ejec.Models;
using Ejec.Profesor.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejec.Profesor.Services
{
    [AbpAuthorize]
    public class ProfessorAppService : AsyncCrudAppService<Professor, ProfessorDto, int>
    {
        public ProfessorAppService(IRepository<Professor, int> repository) : base(repository)
        {
            GetPermissionName = PermissionNames.Pages_Professor;
        }
    }
}
