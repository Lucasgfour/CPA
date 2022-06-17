using CPA.Commom.Models;
using CPA.Commom.Tools;
using CPA.Data.Model;
using CPA.Data.Requests;
using CPA.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CPA.ApplicationWeb.Controller {
    [Route("api/questionario")]
    [ApiController]
    public class QuestionarioController : ControllerBase {

        private readonly IQuestionarioService _questionarioService;

        public QuestionarioController(IQuestionarioService questionarioService) {
            this._questionarioService = questionarioService;
        }

        [HttpGet]
        public ResponseResult<DateTime> Get() {

            return new ResponseResult<DateTime>(true, "", DateTime.Now);

        }

        [Route("id/{id}")]
        [HttpGet]
        public ResponseResult<Questionario> GetById([FromRoute] int id) {

            var questionario = _questionarioService.GetById(id);

            return new ResponseResult<Questionario>(true, "OK", questionario);

        }

        [Route("chave/{chave}")]
        [HttpGet]
        public ResponseResult<Questionario> GetByChave([FromRoute]string chave) {

            var questionario = _questionarioService.GetByChave(chave);

            return new ResponseResult<Questionario>(true, "OK", questionario);

        }

        [HttpPost]
        public ResponseResult<Questionario> Add([FromBody]QuestionarioAddRequest questionario) {

            var newQuestionario = AutoMapper.Map<Questionario>(questionario, new Questionario());

            _questionarioService.Add(newQuestionario, questionario.instituicaoId);

            return new ResponseResult<Questionario>(true, "Cadastrado com sucesso.");

        }

        [HttpPut]
        public ResponseResult<Questionario> Update([FromBody] QuestionarioUpdateRequest questionario) {

            var updQuestionario = AutoMapper.Map<Questionario>(questionario, new Questionario());

            _questionarioService.Update(updQuestionario);

            return new ResponseResult<Questionario>(true, "Alterado com sucesso.");

        }

    }
}
