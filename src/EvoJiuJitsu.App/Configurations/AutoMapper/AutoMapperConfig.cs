using AutoMapper;
using EvoJiuJitsu.App.ViewModels;
using EvoJiuJitsu.Business.Models;

namespace EvoJiuJitsu.App.Configurations.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Atleta, AtletaViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
        }
    }
}
