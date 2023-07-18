namespace Balta.ContextoNotificacao {
    public sealed class Notificacao {
        public Notificacao() {
            
        }
        public Notificacao(string? propriedade, string? mensagem)
        {
            Propriedade = propriedade;
            Mensagem = mensagem;
        }

        public string? Propriedade { get; set; }
        public string? Mensagem { get; set; }
    }
}