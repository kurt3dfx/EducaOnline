using AutoMapper;
using EducaOnline.Conteudo.Application.ViewModels;
using EducaOnline.Conteudo.Domain;

namespace EducaOnline.Conteudo.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Curso, CursoViewModel>()
                //.ForMember(dest => dest.Categoria, opt => opt.MapFrom(src => src.Categoria.Nome))
                .ForMember(dest => dest.CategoriaId, opt => opt.MapFrom(src => src.Categoria.Id));

            CreateMap<Categoria, CategoriaViewModel>();
        }
    }
}
