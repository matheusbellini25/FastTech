using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FastTech.Application.DataTransferObjects;
using FastTech.Application.Interfaces;
using static FastTech.Domain.Constants.AppConstants;

namespace FastTech.Api.Controllers
{
    /// <summary>
    /// Pedido controller
    /// </summary>
    [Route("Pedido")]
    public class PedidoController(ILogger<PedidoController> logger, IPedidoApplicationService PedidoApplicationService) : BaseController(logger)
    {
        private readonly IPedidoApplicationService _PedidoApplicationService = PedidoApplicationService;

        /// <summary>
        /// Criar um novo Pedido
        /// </summary>
        /// <param name="listModel">Objeto com as propriedades para criar um novo Pedido</param>
        /// <returns>Um objeto do Pedido criado</returns>
        [HttpPost]
        [Authorize(Policy = Policies.Cliente)]
        [Produces("application/json")]
        [ProducesResponseType(typeof(Pedido), StatusCodes.Status200OK)]
        public async Task<object> Create([FromBody] List<BasicPedido> listModel)
        {
            try
            {
                List<Pedido> pedido = new List<Pedido>();
                foreach (var item in listModel)
                {
                    pedido.Add(await _PedidoApplicationService.Add(item));
                }
                return Ok(pedido);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
