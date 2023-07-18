using Balta.ContextoCompartilhado;
using Balta.ContextoConteudo.Enums;

namespace Balta.ContextoConteudo {
    public class Aula : Base {
        public int Ordem { get; set; }
        public string? Titulo { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public ENivelConteudo Nivel { get; set; }
    }
} 