using AutoMapper;
using STARAS.BusinessLayer.RequestModels;
using STARAS.BusinessLayer.ResponseModels;
using STARAS.DataLayer.Models;

namespace STARAS.BusinessLayer.AutoMapperModules
{
    public static class StoreModule
    {
        public static void ConfigStoreModule(this IMapperConfigurationExpression mc)
        {
            mc.CreateMap<Store, StoreResponseModel>().ReverseMap();
            mc.CreateMap<Store, StoreRequestModel>().ReverseMap();
        }
    }
}
