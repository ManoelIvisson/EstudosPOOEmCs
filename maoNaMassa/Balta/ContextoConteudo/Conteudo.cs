namespace Balta.ContextoConteudo {
    public abstract class Conteudo {

        public Conteudo(string titulo, string url) {
            Id = Guid.NewGuid();
            Titulo = titulo;
            Url = url;
        }

        public Guid Id { get; set; }
        public string? Titulo { get; set; }
        public string? Url { get; set; }
}
}
