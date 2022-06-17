namespace CPA.Data.Requests {
    public class QuestionarioAddRequest {

        public int instituicaoId { get; set; }
        public DateTime data_inicio { get; set; }
        public String titulo { get; set; } = "";
        public String descricao { get; set; } = "";

    }
}
