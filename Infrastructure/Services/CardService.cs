using Core.DTOs;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Requests;

namespace Infrastructure.Services;

public class CardService : ICardService
{
    private readonly ICardRepository _repository;

    public CardService(ICardRepository repository)
    {
        _repository = repository;
    }

    public async Task<CardDTO> Create(CreateCardRequest request)
    {
        return await _repository.Create(request);
    }

    public async Task<ChargeDTO> CreateCharge(CreateChargeRequest request)
    {
        var isTransactionAllowed = await _repository
            .VerifyChargeAmount(request.CardId, request.Amount);

        if (!isTransactionAllowed) 
            throw new Exception("El monto supera el limite");

        return await _repository.CreateCharge(request);
    }
}
