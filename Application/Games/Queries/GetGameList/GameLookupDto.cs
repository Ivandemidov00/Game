using System;
using Application.Comman.Mappings;
using AutoMapper;
using Domain;

namespace Application.Games.Queries.GetGameList
{
    public class GameLookupDto : IMapWith<Game>
    {
        public Int32 id { get; set; }
        public string name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Game, GameLookupDto>()
                .ForMember(gameDto => gameDto.id,
                    opt => opt.MapFrom(game => game.id))
                .ForMember(gameDto => gameDto.name,
                    opt => opt.MapFrom(game => game.name));
        }
    }
}