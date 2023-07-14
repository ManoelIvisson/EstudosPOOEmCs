using Balta.ContextoConteudo.Enums;

namespace Balta.ContextoConteudo {
    public class Curso : Conteudo {
        public Curso(string titulo, string url) : base(titulo, url) {
            Modulos = new List<Modulo>();
        }

        public string? Tag { get; set; }
        public List<Modulo>? Modulos { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public ENivelConteudo Nivel { get; set; }
}
}