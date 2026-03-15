using AutoMapper;
using SupportTicketSystem.Api.Entities;
using SupportTicketSystem.Api.DTOs;

namespace SupportTicketSystem.Api.Mapping;

public class TicketMappingProfile : Profile
{
    public TicketMappingProfile()
    {
        CreateMap<Ticket, TicketDto>()
            .ForMember(dest => dest.CreatedByUsername,
                opt => opt.MapFrom(src => src.CreatedByUser.Username))
            .ForMember(dest => dest.AssignedAdminUsername,
                opt => opt.MapFrom(src => src.AssignedAdmin.Username));

        CreateMap<TicketComment, TicketCommentDto>()
            .ForMember(dest => dest.CreatedByUsername,
                opt => opt.MapFrom(src => src.CreatedByUser.Username));

        CreateMap<TicketStatusHistory, TicketStatusHistoryDto>()
            .ForMember(dest => dest.UpdatedByUsername,
                opt => opt.MapFrom(src => src.UpdatedByUser.Username));

        CreateMap<User, UserDto>();
    }
}