using Core.DTOs;
using Core.Requests;

namespace Core.Interfaces.Services;

public interface ICardService
{
    Task<CardDTO> Create(CreateCardRequest request);
    Task<ChargeDTO> CreateCharge(CreateChargeRequest request);
}
