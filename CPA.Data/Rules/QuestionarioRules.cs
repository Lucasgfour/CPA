using CPA.Commom.ClassRules;
using CPA.Data.Interface;
using CPA.Data.Model;

namespace CPA.Data.Rules {
    public class QuestionarioRules : IRules<Questionario> {

        private RulesValidation rule = new RulesValidation();

        public void ValidationInsert(Questionario obj) {

            rule.isNullOrEmpty(obj.titulo, "Obrigatório informar um título.");
            rule.isNullOrEmpty(obj.descricao, "Obrigatório informar uma descrição.");
            rule.isTrue(obj.data_inicio < DateTime.Now, "Data de início menor que data atual.");
            rule.isTrue(obj.instituicao == null, "Instituição informada é inválida.");

            rule.notifications.CauseThrowIfHaveNotifications();

        }

        public void ValidationUpdate(Questionario obj) {

            rule.isNullOrEmpty(obj.titulo, "Obrigatório informar um título.");
            rule.isNullOrEmpty(obj.descricao, "Obrigatório informar uma descrição.");

            rule.notifications.CauseThrowIfHaveNotifications();

        }

    }
}
