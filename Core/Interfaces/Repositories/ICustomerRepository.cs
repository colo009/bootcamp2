using Core.Entities;

namespace Core.Interfaces.Repositories;

public interface ICustomerRepository
{
    List<Customer> List();
    Customer Get(int id);
    List<Customer> Add(string name);
    List<Customer> Update(int id, string name);
    List<Customer> Delete(int id);
}
