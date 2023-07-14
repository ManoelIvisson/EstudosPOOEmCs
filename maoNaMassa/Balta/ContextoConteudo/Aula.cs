using Balta.ContextoConteudo.Enums;

namespace Balta.ContextoConteudo {
    public class Aula {
        public int Ordem { get; set; }
        public string? Titulo { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public ENivelConteudo Nivel { get; set; }
    }
} 