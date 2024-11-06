using Core.Entities;
using Core.Interfaces.Repositories;

namespace Infrastructure.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private static List<Customer> _customers = [
        new(){ Id = 1, Name = "Jose" },
        new(){ Id = 2, Name = "Juan" },
];

    public List<Customer> Add(string name)
    {
        var newCustomer = new Customer
        {
            Id = _customers.Max(x => x.Id) + 1,
            Name = name
        };
        _customers.Add(newCustomer);

        return _customers;
    }

    public List<Customer> Delete(int id)
    {
        var customerToDelete = _customers.FirstOrDefault(x => x.Id == id);
        
        if (customerToDelete is null) throw new Exception("No se encontro con el id solicitado");

        _customers.Remove(customerToDelete);

        return _customers;
    }

    public Customer Get(int id)
    {
        var customer = _customers.FirstOrDefault(x => x.Id == id);

        if (customer is null) throw new Exception("No se encontro con el id solicitado");

        return customer;
    }

    public List<Customer> List()
    {
        return _customers;
    }

    public List<Customer> Update(int id, string name)
    {
        var customer = _customers.FirstOrDefault(x => x.Id == id);

        if (customer is null) throw new Exception("No se encontro con el id solicitado");

        customer.Name = name;

        return _customers;
    }
}
