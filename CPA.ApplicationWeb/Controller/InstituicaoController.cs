using CPA.ApplicationWeb.Response;
using CPA.Commom.Models;
using CPA.Data.Model;
using CPA.Service.Interface;
using CPA.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace CPA.ApplicationWeb.Controller {

    [Route("api/instituicao")]
    [ApiController]
    public class InstituicaoController : ControllerBase {

        private readonly IInstituicaoService _instituicaoService;

        public InstituicaoController(IInstituicaoService instituicaoService) {
            this._instituicaoService = instituicaoService;
        }

        [Route("id/{id}")]
        [HttpGet]
        public ResponseResult<Instituicao> GetById([FromRoute] int id) {

            var instituicao = _instituicaoService.GetById(id);

            return new ResponseResult<Instituicao>(true, "OK", instituicao);

        }

        [Route("login")]
        [HttpPost]
        public ResponseResult<Instituicao> GetByLogin([FromBody] LoginResponse login) {

            var instituicao = _instituicaoService.GetByLogin(login.email, login.password);

            return new ResponseResult<Instituicao>(true, "Logado com sucesso.");

        }

        [HttpPost]
        public ResponseResult<Instituicao> Add([FromBody] Instituicao instituicao) {

            _instituicaoService.Add(instituicao);

            return new ResponseResult<Instituicao>(true, "Inserido com sucesso.");

        }

    }
}
