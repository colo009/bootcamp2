using Core.Entities;
using Core.Interfaces.Repositories;

namespace Infrastructure.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private static List<Customer> _customers = [
        new(){ Id = 1, Name = "Jose" },
        new(){ Id = 2, Name = "Juan" },
];

    public List<Customer> List()
    {
        return _customers;
    }

    //Tarea
    //Agregar
    //Actualizar
    //Eliminar
    //Obtener por Id
}
