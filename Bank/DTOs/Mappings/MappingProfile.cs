using AutoMapper;
using Bank.Models;

namespace Bank.DTOs.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BancoModel, BancoResponse>().ReverseMap();
            CreateMap<EnderecoModel, EnderecoResponse>().ReverseMap();
        }
    }
}
