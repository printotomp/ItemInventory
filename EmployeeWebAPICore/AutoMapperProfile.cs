using AutoMapper;
using ShopBridgeWebAPICore.DTO;
using ShopBridgeWebAPICore.Models;

namespace ShopBridgeWebAPICore
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ItemDTO, Item>().ReverseMap();
        }
    }
}