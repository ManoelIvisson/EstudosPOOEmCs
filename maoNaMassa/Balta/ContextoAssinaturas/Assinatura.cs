namespace Balta.ContextoAssinaturas {
    public class Assinatura {
        public Assinatura() {
            Plano = new Plano();
        }
        public Plano Plano { get; set; }
        public DateTime? DataFinal { get; set; }
        public bool EstaInativo => DataFinal <= DateTime.Now;
}
}
