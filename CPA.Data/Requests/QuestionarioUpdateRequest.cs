namespace CPA.Data.Requests {
    public class QuestionarioUpdateRequest {

        public int id { get; set; }
        public DateTime? data_inicio { get; set; }
        public DateTime? data_fim { get; set; }
        public String titulo { get; set; } = "";
        public String descricao { get; set; } = "";

    }
}
