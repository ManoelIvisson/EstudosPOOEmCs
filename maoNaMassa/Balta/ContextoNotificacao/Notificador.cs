namespace Balta.ContextoNotificacao {
    public abstract class Notificador {
        public Notificador(){
            Notificacoes = new List<Notificacao>();
        }
        public List<Notificacao> Notificacoes { get; set; }

        public void AddNotificacao(Notificacao notificacao) {
            Notificacoes?.Add(notificacao);
        }

        public void AddNotificacoes(IEnumerable<Notificacao> notificacoes) {
            Notificacoes?.AddRange(notificacoes);
        }
        
        public bool EInvalido => Notificacoes.Any();
    }
}