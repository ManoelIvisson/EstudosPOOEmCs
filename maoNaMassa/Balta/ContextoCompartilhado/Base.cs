using Balta.ContextoNotificacao;

namespace Balta.ContextoCompartilhado {
    public abstract class Base : Notificador{
        public Base() {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
}
}
