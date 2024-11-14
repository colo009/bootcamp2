using Core.DTOs;
using Core.Entities;
using Core.Requests;
using Mapster;

namespace Infrastructure.Mapping;

public class CardMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<CreateCardRequest, Card>();

        config.NewConfig<Card, CardDTO>();

        config.NewConfig<CreateChargeRequest, Charge>()
            .Map(dest => dest.TransactionDate, opt => DateTime.UtcNow);

        config.NewConfig<Charge, ChargeDTO>()
            .Map(dest => dest.TransactionDate, src => src.TransactionDate.ToShortDateString())
            .Map(dest => dest.Balance, src => src.Card.Limit - src.Card.Debt);
    }
}
