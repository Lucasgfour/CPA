namespace CPA.Data.Model {
    public class OpcaoResposta {

        public int id { get; set; }
        public Pergunta? pergunta { get; set; }
        public String? valor { get; set; }

    }
}
