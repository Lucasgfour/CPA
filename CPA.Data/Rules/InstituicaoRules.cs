using CPA.Commom.ClassRules;
using CPA.Data.Interface;
using CPA.Data.Model;

namespace CPA.Data.Rules {
    public class InstituicaoRules : IRules<Instituicao> {

        private RulesValidation rule = new RulesValidation();

        public void ValidationInsert(Instituicao obj) {

            rule.isNullOrEmpty(obj.senha, "Obrigatório informar uma senha.");

            ValidationUpdate(obj);

        }

        public void ValidationUpdate(Instituicao obj) {

            rule.isNullOrEmpty(obj.nome, "Obrigatório informar nome.");
            rule.isNullOrEmpty(obj.email, "Obrigatório informar email.");

            rule.isLengthLessThan(obj.documento, 18, "CNPJ informado é inválido.");
            rule.isNullOrEmpty(obj.presidenteCpa, "Necessário informar responsável CPA.");

            rule.notifications.CauseThrowIfHaveNotifications();

        }
    }
}
