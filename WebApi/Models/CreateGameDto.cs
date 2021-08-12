using Application.Comman.Mappings;
using Application.Games.Command.CreateGame;
using AutoMapper;

namespace WebApi.Models
{
    public class CreateGameDto: IMapWith<CreateGameCommand>
    {
        public string Name { get; set; }
        public string Studio { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateGameDto, CreateGameCommand>()
                .ForMember(gameCommand => gameCommand.Name,
                    opt => opt.MapFrom(gameDto => gameDto.Name))
                .ForMember(gameCommand => gameCommand.Studio,
                    opt => opt.MapFrom(gameDto => gameDto.Studio));
        }
}