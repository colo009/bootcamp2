using Core.DTOs;
using Core.Entities;
using Mapster;

namespace Infrastructure.Mapping;

public class CustomerMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Customer, CustomerDTO>()
            .Map(dest => dest.Id, src => src.Id)
            .Map(dest => dest.Phone, src => src.Phone)
            .Map(dest => dest.Email, src => src.Email)
            .Map(dest => dest.FullName, src => $"{src.FirstName} {src.LastName}")
            .Map(dest => dest.BirthDate, src => src.BirthDate.ToShortDateString());

        config.NewConfig<Customer, CustomerProductsDTO>()
            .Map(dest => dest.FullName, src => $"{src.FirstName} {src.LastName}")
            .Map(dest => dest.Products, src => src.CustomerEntities);

        config.NewConfig<CustomerEntity, EntityProductsDTO>()
            .Map(dest => dest.EntityName, src => src.Entity.Name)
            .Map(dest => dest.Products, src => src.CustomerEntityProducts);

        config.NewConfig<CustomerEntityProduct, ProductDTO>()
            .Map(dest => dest.Id, src => src.EntityProduct.Id)
            .Map(dest => dest.Name, src => src.EntityProduct.Name);
            
    }
}
