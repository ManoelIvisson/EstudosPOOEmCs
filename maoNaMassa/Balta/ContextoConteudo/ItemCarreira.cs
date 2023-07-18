using Balta.ContextoCompartilhado;
using Balta.ContextoNotificacao;

namespace Balta.ContextoConteudo {
    public class ItemCarreira : Base {
        public ItemCarreira(int ordem, string? titulo, string? descricao, Curso? curso)
        {
            if (curso == null) {
                AddNotificacao(new Notificacao("Curso", "Curso Inválido"));
            }
            Ordem = ordem;
            Titulo = titulo;
            Descricao = descricao;
            Curso = curso;
        }

        public int Ordem { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public Curso? Curso { get; set; }
    }
}