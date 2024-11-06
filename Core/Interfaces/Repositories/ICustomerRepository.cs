using Core.Entities;

namespace Core.Interfaces.Repositories;

public interface ICustomerRepository
{
    List<Customer> List();
}
