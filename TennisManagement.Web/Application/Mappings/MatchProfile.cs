namespace TennisManagement.Web.Application.Mappings
{
using AutoMapper;
    using TennisManagement.Web.Models.Matches;
    using TennisManagement.Web.ViewModels.Matches;

    public class MatchProfile : Profile
    {
        public MatchProfile() 
        {
            this.CreateMap<MatchFormViewModel, Match>();
            this.CreateMap<Match, MatchFormViewModel>();

            this.CreateMap<Match, MatchDetailsViewModel>()
                .ForMember(dest => dest.VenueName,
                opt => opt
                .MapFrom(src => src.Venue.Name))
                .ForMember(dest => dest.TournamentName,
                opt => opt
                .MapFrom(src => src.Tournament.Name))
                .ForMember(dest => dest.FirstPlayerFullName,
                opt => opt
                .MapFrom(src => $"{src.FirstPlayer.FirstName} " +
                $"{src.FirstPlayer.LastName}"))
                .ForMember(dest => dest.SecondPlayerFullName,
                opt => opt
                .MapFrom(src => $"{src.SecondPlayer.FirstName} " +
                $"{src.SecondPlayer.LastName}"))
                .ForMember(dest => dest.WinnerFullName,
                opt => opt
                .MapFrom(src => src.Winner != null ? $"{src.Winner.FirstName} " +
                $"{src.Winner.LastName}" : null));


            this.CreateMap<Match, MatchInfoViewModel>()
                .ForMember(dest => dest.VenueName, 
                opt => opt
                .MapFrom(src => src.Venue.Name))
                .ForMember(dest => dest.TournamentName, 
                opt => opt
                .MapFrom(src => src.Tournament.Name))
                .ForMember(dest => dest.FirstPlayerFullName, 
                opt => opt
                .MapFrom(src => $"{src.FirstPlayer.FirstName} " +
                $"{src.FirstPlayer.LastName}"))
                .ForMember(dest => dest.SecondPlayerFullName, 
                opt => opt
                .MapFrom(src => $"{src.SecondPlayer.FirstName} " +
                $"{src.SecondPlayer.LastName}"))
                .ForMember(dest => dest.WinnerFullName, 
                opt => opt
                .MapFrom(src => src.Winner != null ? $"{src.Winner.FirstName} " +
                $"{src.Winner.LastName}" : null));
        }
    }
}
