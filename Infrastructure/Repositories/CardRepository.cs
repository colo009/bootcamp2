using Core.DTOs;
using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Requests;
using Infrastructure.Contexts;
using Mapster;

namespace Infrastructure.Repositories;

public class CardRepository : ICardRepository
{
    private readonly ApplicationDbContext _context;

    public CardRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<CardDTO> Create(CreateCardRequest request)
    {
        var cardToCreate = request.Adapt<Card>();

        _context.Cards.Add(cardToCreate);
        await _context.SaveChangesAsync();
        
        return cardToCreate.Adapt<CardDTO>();
    }

    public async Task<ChargeDTO> CreateCharge(CreateChargeRequest request)
    {
        var chargeToCreate = request.Adapt<Charge>();

        var card = await _context.Cards.FindAsync(request.CardId);
        card!.Debt += request.Amount;

        _context.Charges.Add(chargeToCreate);

        await _context.SaveChangesAsync();

        return chargeToCreate.Adapt<ChargeDTO>();
    }

    public async Task<bool> VerifyChargeAmount(int cardId, decimal amount)
    {
        var card = await _context.Cards.FindAsync(cardId);

        if (card is null) 
            throw new Exception("No se encontro la tarjeta con el id provisto");

        return card.Limit - card.Debt >= amount;
    }
}
