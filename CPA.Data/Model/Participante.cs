namespace CPA.Data.Model {
    public class Participante {

        public int id { get; set; }
        public String? chave { get; set; }
        public Questionario? questionario { get; set; }
        public DateTime data_resposta { get; set; }


    }
}
