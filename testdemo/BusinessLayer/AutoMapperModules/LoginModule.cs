using AutoMapper;

namespace STARAS.BusinessLayer.AutoMapperModules
{
    public static class LoginModule
    {
        public static void ConfigLoginModule(this IMapperConfigurationExpression mc)
        {
            //mc.CreateMap<Account, AccountAllResponseModel>().ReverseMap();
        }
    }
}
