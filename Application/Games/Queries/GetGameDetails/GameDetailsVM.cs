using System;
using Application.Comman.Mappings;
using AutoMapper;
using Domain;

namespace Application.Games.Queries.GetGameDetails
{
    public class GameDetailsVM:IMapWith<Game>
    {
        public Guid id { get; set; }
        public String name { get; set; }
        public String studio { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Game, GameDetailsVM>()
                .ForMember(g => g.name,
                    opt => opt.MapFrom(g => g.name))
                .ForMember(g => g.studio,
                    opt => opt.MapFrom(g => g.studio));
                
        }
    }
}