using CPA.Data.Enum;

namespace CPA.Data.Model {
    public class Pergunta {

        public int id { get; set; }
        public Questionario? questionario { get; set; }
        public Permissao aluno { get; set; }
        public Permissao professor { get; set; }
        public Permissao administrativo { get; set; }
        public String? descricao { get; set; }
        public TipoPergunta tipo { get; set; }
        public int posicao { get; set; }

        public List<OpcaoResposta>? opcaoRespostas { get; set; }

    }
}
