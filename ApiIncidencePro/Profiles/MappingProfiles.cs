using ApiIncidencePro.Dtos;
using AutoMapper;
using Domain.Entities;

namespace ApiIncidencePro.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles(){
        CreateMap<Incidence, IncidenceDto>().ReverseMap();
        CreateMap<IncidenceDetail, IncidenceDetailDto>().ReverseMap();
    }
}