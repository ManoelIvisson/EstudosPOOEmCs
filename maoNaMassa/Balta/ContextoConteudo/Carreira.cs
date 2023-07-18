using Balta.ContextoCompartilhado;

namespace Balta.ContextoConteudo {
    public class Carreira : Conteudo {
        public Carreira(string titulo, string url) 
         : base(titulo, url)
        {
            Itens = new List<ItemCarreira>();
        }
        public List<ItemCarreira> Itens { get; set; }
        public int TotalItens => Itens.Count;
}
}
