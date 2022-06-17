namespace CPA.Data.Model {
    public class Questionario {

        public int id { get; set; }
        public Instituicao? instituicao { get; set; }
        public DateTime? data_inicio { get; set; }
        public DateTime? data_fim { get; set; }
        public String? titulo { get; set; }
        public String chave { get; set; } = "";
        public String? descricao { get; set; }

    }
}
