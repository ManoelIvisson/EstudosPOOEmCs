namespace Balta.ContextoConteudo {
     public class Modulo {
        public Modulo() {
            Aulas = new List<Aula>();
        }
        public int Ordem { get; set; }
        public string? Titulo { get; set; }
        public List<Aula>? Aulas { get; set; }
    }
}
 