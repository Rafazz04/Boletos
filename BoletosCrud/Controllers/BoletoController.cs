using BoletosCrud.Dtos;
using BoletosCrud.Models;
using BoletosCrud.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletosCrud.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BoletoController : ControllerBase
{
    private readonly IBoletoService _booletoService;

    public BoletoController(IBoletoService booletoService)
    {
        _booletoService = booletoService;
    }

    [HttpPost]
    public ActionResult<BoletoDTO> PostBoleto(BoletoDTO boletoDTO)
    {
        try
        {
            if(!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage));
                return BadRequest(errors);
            }
            var boleto = _booletoService.CreateBoleto(boletoDTO);
            if (boleto != null)
                return StatusCode(201, boleto);
            return BadRequest();
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro interno do servidor: {ex.Message} - {ex.StackTrace}");
        }
    }

    [HttpGet("GetById")]
    public ActionResult<BoletoDTO> GetById(int id)
    {
        try
        {
            var boleto = _booletoService.GetById(id);
            if (boleto != null)
                return Ok(boleto);
            return BadRequest();
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro interno do servidor: {ex.Message} - {ex.StackTrace}");
        }
    }
}
