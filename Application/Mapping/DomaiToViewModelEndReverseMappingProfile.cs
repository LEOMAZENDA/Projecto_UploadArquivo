using Application.ViewsModels;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping
{
    public class DomaiToViewModelEndReverseMappingProfile : Profile
    {
        public DomaiToViewModelEndReverseMappingProfile()
        {
            CreateMap<Ficheiro, FicheiroVM>().ReverseMap();
        }
    }
}
