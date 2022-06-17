namespace CPA.Data.Model {
    public class Resposta {

        public int id { get; set; }
        public Participante? participante { get; set; }
        public Pergunta? pergunta { get; set; }
        public string? valor { get; set; }

    }
}
