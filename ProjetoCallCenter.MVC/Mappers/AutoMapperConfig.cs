using AutoMapper;
using ProjetoCallCenter.Domain.Entities;
using ProjetoCallCenter.MVC.ViewModels;

namespace ProjetoCallCenter.MVC.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x=>
            {
                x.CreateMap<Usuario, UsuarioViewModel>();
                x.CreateMap<Credencial, CredencialViewModel>();
                x.CreateMap<Credor, CredorViewModel>();
                x.CreateMap<Segmentacao, SegmentacaoViewModel>();

                x.CreateMap<UsuarioViewModel, Usuario>();
                x.CreateMap<CredencialViewModel, Credencial>();
                x.CreateMap<CredorViewModel, Credor>();
                x.CreateMap<SegmentacaoViewModel, Segmentacao>();
            });
        }
    }
}