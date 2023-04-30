using AutoMapper;
using Commands;
using Commands.Interfaces;
using Invokers;
using Microsoft.AspNetCore.Mvc;
using Model;
using View.Request;

namespace ProcessamentoDadosPorNotificacao.Controller
{
    /// <summary>
    /// Classe responsavel por receber a requisição e passar para a camada
    /// de presenters.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ProcessarDadosController : ControllerBase
    {
        private readonly CommandInvoker _invoker;
        private readonly IMapper _mapper;

        /// <summary>
        /// Controller
        /// </summary>
        /// <param name="invoker"></param>
        public ProcessarDadosController(CommandInvoker invoker, IMapper mapper)
        {
            _invoker = invoker;
            _mapper = mapper;
        }

        /// <summary>
        /// Recebe lista de dados e transforma em excel usando stimusolft
        /// </summary>
        /// <param name="request">Lista de dados</param>
        /// <returns>CalcularAcumuloTaxaRendimentoAsync</returns>
        [HttpGet("/api/receive/data")]
        public IActionResult GerarExcelStimusolft([FromBody] List<DadosRequest> request)
        {
            ICommand gerarExcelStimulsoft = new GerarExcelStimulsoftCommand(_mapper.Map<List<Dados>>(request));
            _invoker.SetCommand(gerarExcelStimulsoft);
            _invoker.ExecuteCommand();
            return Ok();
        }

    }
}
