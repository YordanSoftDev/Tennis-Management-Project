namespace TennisManagement.Web.Application.Mappings.Roster
{
    using AutoMapper;
    using TennisManagement.Web.Models.Roster;
    using TennisManagement.Web.ViewModels.Roster;

    public class PlayerProfile : Profile
    {
        public PlayerProfile()
        {
            this.CreateMap<PlayerFormViewModel, Player>();
            this.CreateMap<Player, PlayerFormViewModel>();

            this.CreateMap<Player, PlayerDetailsViewModel>()
                .ForMember(dest => dest.FullName, opt => opt
                .MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.Country, opt => opt
                .MapFrom(src => src.Country.Name));

            this.CreateMap<Player, PlayerInfoViewModel>()
                .ForMember(dest => dest.FullName, opt => opt
                .MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.Country, opt => opt
                .MapFrom(src => src.Country.Name));


        }
    }
}
