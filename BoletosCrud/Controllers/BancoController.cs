using BoletosCrud.Dtos;
using BoletosCrud.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BoletosCrud.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BancoController : ControllerBase
{
    private readonly IBancoService _bancoService;

    public BancoController(IBancoService bancoService)
    {
        _bancoService = bancoService;
    }

    [HttpPost]
    public ActionResult<BancoDTO> PostBanco(BancoDTO bancoDTO)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors.Select(e => e.ErrorMessage));
                return BadRequest(errors);
            }
            var banco = _bancoService.CreateBanco(bancoDTO);
            if (banco != null)
                return StatusCode(201, banco);
            return BadRequest();
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro interno do servidor: {ex.Message} - {ex.StackTrace}");
        }
    }

    [HttpGet("GetAll")]
    public ActionResult<List<BancoDTO>> GetAllBanco()
    {
        try
        {
            var banco = _bancoService.GetAll();
            if(banco != null)
                return Ok(banco);
            return BadRequest();
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro interno do servidor: {ex.Message} - {ex.StackTrace}");
        }
    }

    [HttpGet("GetByCod")]
    public ActionResult<BancoDTO> GetCodBanco(string codigo)
    {
        try
        {
            var banco = _bancoService.GetByCod(codigo);
            if(banco != null)
                return Ok(banco);
            return BadRequest();
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro interno do servidor: {ex.Message} - {ex.StackTrace}");
        }
    }
}
