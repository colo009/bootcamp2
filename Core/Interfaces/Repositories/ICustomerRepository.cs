using Core.DTOs;

namespace Core.Interfaces.Repositories;

public interface ICustomerRepository
{
    Task<List<CustomerDTO>> List();
    Task<CustomerDTO> Get(int id);
    Task<List<CustomerDTO>> Add(string firstName, string? lastName);
    Task<List<CustomerDTO>> Update(int id, string firstName, string? lastName);
    Task<List<CustomerDTO>> Delete(int id);
}
