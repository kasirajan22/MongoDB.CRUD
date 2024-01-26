using AutoMapper;

namespace MongoDB.CRUD;

public class MusicMapper : Profile 
{
    public MusicMapper()
    {
        // Source ==> Target
        CreateMap<Music, MusicDTO>();
        CreateMap<MusicDTO, Music>();
    }
}