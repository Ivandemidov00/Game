using System;
using Application.Comman.Mappings;
using Application.Games.Command.UpdateGame;
using AutoMapper;

namespace WebApi.Models
{
    public class UpdateGameDto : IMapWith<UpdateGameCommand>
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Studio { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateGameDto, UpdateGameCommand>()
                .ForMember(gameCommand => gameCommand.Id,
                    opt => opt.MapFrom(gameDto => gameDto.Id))
                .ForMember(gameCommand => gameCommand.Name,
                    opt => opt.MapFrom(gameDto => gameDto.Name))
                .ForMember(gameCommand => gameCommand.Studio,
                    opt => opt.MapFrom(gameDto => gameDto.Studio));
        }
    }
}