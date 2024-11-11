using Core.DTOs;
using Core.Interfaces.Repositories;
using Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly ApplicationDbContext _context;

    public AccountRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<DetailedAccountDTO> GetById(int id)
    {
        var account = await _context.Accounts
            .Include(x => x.Customer)
            .FirstOrDefaultAsync(x => x.Id == id);

        if (account == null) 
            throw new Exception("La cuenta con el id solicitado no existe");

        return new DetailedAccountDTO
        {
            Id = account.Id,
            Balance = account.Balance,
            Number = account.Number,
            OpeningDate = account.OpeningDate.ToShortDateString(),
            Customer = new CustomerDTO
            {
                Id = account.Customer.Id,
                Email = account.Customer.Email,
                Phone = account.Customer.Phone,
                FullName = $"{account.Customer.FirstName} {account.Customer.LastName}",
                BirthDate = account.Customer.BirthDate.ToShortDateString()
            }
        };
    }
}
