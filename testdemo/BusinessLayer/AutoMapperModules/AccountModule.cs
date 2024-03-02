using AutoMapper;
using STARAS.BusinessLayer.RequestModels;
using STARAS.BusinessLayer.ResponseModels;
using STARAS.DataLayer.Models;

namespace STARAS.BusinessLayer.AutoMapperModules
{
    public static class AccountModule
    {
        public static void ConfigAccountModule(this IMapperConfigurationExpression mc)
        {
            mc.CreateMap<Account, AccountAllResponseModel>().ReverseMap();
            mc.CreateMap<Account, AccountResponseModel>().ReverseMap();
        }
    }
}
