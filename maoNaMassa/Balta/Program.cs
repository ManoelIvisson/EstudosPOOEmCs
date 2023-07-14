using Balta.ContextoConteudo;

class Program {
    public static void Main(string[] args){
        var artigos = new List<Artigo>();
        artigos.Add(new Artigo("Chat-GPT tomou o trabalho de 100% dos programadores", "tomou-emprego"));
        artigos.Add(new Artigo("Orientação a objetos VS Eu", "orientacao-objetos"));
        artigos.Add(new Artigo("Computadores não existem mais", "computadores"));

        foreach (var artigo in artigos) {
            Console.WriteLine(artigo.Id);
            Console.WriteLine(artigo.Titulo);
            Console.WriteLine(artigo.Url);
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
    }
}