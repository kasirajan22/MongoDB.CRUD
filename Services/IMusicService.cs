namespace MongoDB.CRUD;

public interface IMusicService
{
    Task<Music> AddMusic(Music music);
    Task<Music> EditMusic(Music music);
    bool DeleteMusic(string id);
    IEnumerable<Music> List();
    Music Details(string id);
}