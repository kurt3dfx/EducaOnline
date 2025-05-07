using EducaOnline.Conteudo.Application.ViewModels;
using EducaOnline.Conteudo.Domain;
using AutoMapper;

namespace EducaOnline.Conteudo.Application.AutoMapper
{
    public class ViewModeltoDomainMappingProfile : Profile
    {
        public ViewModeltoDomainMappingProfile()
        {
            CreateMap<CursoViewModel, Curso>()
                .ForMember(dest => dest.Categoria, opt => opt.Ignore());
            //.ForMember(dest => dest.Aulas, opt => opt.Ignore());

            CreateMap<CategoriaViewModel, Categoria>()
                .ConstructUsing(c=> new Categoria (c.Nome, c.Codigo));
        }
    }
}
