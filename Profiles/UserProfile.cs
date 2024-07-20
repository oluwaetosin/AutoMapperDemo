using AutoMapper;
using AutoMapperDemo.Models;

namespace AutoMapperDemo.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<Document, DocumentDto>()
        .ForMember(dest => dest.DocumentName, opt => opt.MapFrom(src => src.Name));

    }
}
