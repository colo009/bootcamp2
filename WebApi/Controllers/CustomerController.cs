using Core.Entities;
using Core.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class CustomerController : BaseApiController
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerController(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    [HttpGet("list")]
    public IActionResult List()
    {
        return Ok(_customerRepository.List());
    }

    [HttpGet("{id}")]
    public IActionResult Get([FromRoute] int id)
    {
        return Ok(_customerRepository.Get(id));
    }

    [HttpPost("add")]
    public IActionResult Add([FromBody] Customer customer)
    {
        return Ok(_customerRepository.Add(customer.Name));
    }

    [HttpPut("update")]
    public IActionResult Update([FromBody] Customer customer)
    {
        return Ok(_customerRepository.Update(customer.Id, customer.Name));
    }

    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] int id)
    {
        return Ok(_customerRepository.Delete(id));
    }
}
