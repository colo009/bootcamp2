using Core.DTOs;

namespace Core.Interfaces.Repositories;

public interface IAccountRepository
{
    Task<DetailedAccountDTO> GetById(int id);
}
