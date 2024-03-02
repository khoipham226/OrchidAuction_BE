using Microsoft.AspNetCore.Http;
using STARAS.BusinessLayer.ResponseModels;
using STARAS.BusinessLayer.Utilities.Enums;
using System.Security.Claims;

namespace STARAS.BusinessLayer.Utilities.Commons
{
    public static class Commons
    {
        public static int ConvertStringRoleToInt(string role)
        {
            if (role == Roles.SystemAdmin.GetDisplayName())
                return (int)Roles.SystemAdmin;
            else if (role == Roles.HRManager.GetDisplayName())
                return (int)Roles.HRManager;
            else if (role == Roles.StoreManager.GetDisplayName())
                return (int)Roles.StoreManager;
            else
                return (int)Roles.Employee;
        }

        public static CurrentLoginInfor GetCurrentLoginInfor(IHttpContextAccessor httpContextAccessor)
        {
            try
            {
                var Id = short.Parse(httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier).Value);
                var name = httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.Name).Value;
                var roleId = short.Parse(httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.Role).Value);
                var companyId = short.Parse(httpContextAccessor.HttpContext?.User.FindFirst("CompanyId").Value);
                CurrentLoginInfor currentLoginInfor = new CurrentLoginInfor
                {
                   Id = Id,
                   Name = name,
                   RoleId = roleId,
                   CompanyId = companyId,
                };
                return currentLoginInfor;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred:" + ex.Message);
            }
        }
    }
}
