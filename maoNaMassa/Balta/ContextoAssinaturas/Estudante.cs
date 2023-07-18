using Balta.ContextoCompartilhado;
using Balta.ContextoNotificacao;

namespace Balta.ContextoAssinaturas {
    public class Estudante : Base{
        public Estudante() {
            Assinaturas = new List<Assinatura>();
        }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public Usuario? usuario { get; set; }
        public List<Assinatura> Assinaturas { get; set; }
        public bool Premium => Assinaturas.Any(x => !x.EstaInativo);

        public void CriarAssinatura(Assinatura assinatura) {
            if (Premium) {
                AddNotificacao(new Notificacao("Premium", "O aluno já possui uma assinatura ativa"));
                return;
            } else {
                Assinaturas.Add(assinatura);
            }
        }
}
}
