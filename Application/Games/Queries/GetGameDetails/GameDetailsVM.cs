using System;
using AutoMapper;
using Domain;

namespace Application.Games.Queries.GetGameDetails
{
    public class GameDetailsVM
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Studio { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Game, GameDetailsVM>()
                .ForMember(g => g.Name,
                    opt => opt.MapFrom(g => g.Name))
                .ForMember(g => g.Studio,
                    opt => opt.MapFrom(g => g.Studio));
                
        }
    }
}