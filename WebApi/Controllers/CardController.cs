using Core.Interfaces.Services;
using Core.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class CardController : BaseApiController
{
    private readonly ICardService _service;

    public CardController(ICardService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateCardRequest request)
    {
        return Ok(await _service.Create(request));
    }

    [HttpPost("charge")]
    public async Task<IActionResult> CreateCharge([FromBody] CreateChargeRequest request)
    {
        return Ok(await _service.CreateCharge(request));
    }
}
