using Core.DTOs;
using Core.Requests;

namespace Core.Interfaces.Repositories;

public interface ICardRepository
{
    Task<CardDTO> Create(CreateCardRequest request);
    Task<ChargeDTO> CreateCharge(CreateChargeRequest request);

    /// <summary>
    /// Verifica si el monto de la transaccion es permitido. Retorna true si es permitido.
    /// </summary>
    /// <param name="cardId"></param>
    /// <param name="amount"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    Task<bool> VerifyChargeAmount(int cardId, decimal amount);
}
