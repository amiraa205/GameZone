namespace GameZone.Services;

public interface IGamesService
{
    IEnumerable<Game> GetAll(); //games
    Game? GetById(int id);
    // to add new game in db
    Task Create(CreateGameFormViewModel model);
    Task<Game?> Update(EditGameFormViewModel model);
    bool Delete(int id);
}