using System;
using Application.Comman.Mappings;
using AutoMapper;
using Domain;

namespace Application.Games.Queries.GetGameList
{
    public class GameLookupDto : IMapWith<Game>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Game, GameLookupDto>()
                .ForMember(gameDto => gameDto.Id,
                    opt => opt.MapFrom(game => game.Id))
                .ForMember(gameDto => gameDto.Name,
                    opt => opt.MapFrom(game => game.Name));
        }
    }
}