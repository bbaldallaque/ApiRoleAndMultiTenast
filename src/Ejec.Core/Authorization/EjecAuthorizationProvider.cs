using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace Ejec.Authorization
{
    public class EjecAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Professor, L("Professor"));
            context.CreatePermission(PermissionNames.colegio_Professor, L("Professor"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, EjecConsts.LocalizationSourceName);
        }
    }
}
