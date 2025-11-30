using FIAP.FCG.User.Service.Dto.Game;

namespace FIAP.FCG.User.Service.Interfaces;
public interface IGameService
{
    ICollection<GameOutputDto> GetAll();
    GameOutputDto? GetById(long id);
    void Create(GameCreateDto entity);
    void Update(GameUpdateDto entity);
    void DeleteById(long id);
}
