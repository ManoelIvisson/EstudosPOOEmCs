using Balta.ContextoAssinaturas;
using Balta.ContextoConteudo;

class Program {
    public static void Main(string[] args){
        var artigos = new List<Artigo>();
        artigos.Add(new Artigo("Chat-GPT tomou o trabalho de 100% dos programadores", "tomou-emprego"));
        artigos.Add(new Artigo("Orientação a objetos VS Eu", "orientacao-objetos"));
        artigos.Add(new Artigo("Computadores não existem mais", "computadores"));

        // foreach (var artigo in artigos) {
        //     Console.WriteLine(artigo.Id);
        //     Console.WriteLine(artigo.Titulo);
        //     Console.WriteLine(artigo.Url);
        //     Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        // }

        var cursos = new List<Curso>();
        var cursoCs = new Curso("Fundamentos de C#", "fundamentos-cs");
        var cursoPoo = new Curso("Fundamentos de POO", "fundamentos-poo");
        var cursoBd = new Curso("Fundamentos de Banco de Dados", "fundamentos-bd");
        cursos.Add(cursoCs);
        cursos.Add(cursoPoo);
        cursos.Add(cursoBd);

        var carreiras = new List<Carreira>();
        var carreira = new Carreira("Especialista .NET", "especialista-dotnet");
        var itemCarreira = new ItemCarreira(1, "Comece por aqui", "É importante que você comece por aqui", null);
        var itemCarreira2 = new ItemCarreira(2, "Aprenda POO", "É importante que você aprenda POO", cursoPoo);
        var itemCarreira3 = new ItemCarreira(3, "Aprenda Banco de Dados", "É importante que você tenha um banco para guardar seus dados", cursoBd);
        carreira.Itens.Add(itemCarreira3);
        carreira.Itens.Add(itemCarreira);
        carreira.Itens.Add(itemCarreira2);
        carreiras.Add(carreira);

        foreach (var carreira1 in carreiras) {
            Console.WriteLine(carreira1.Titulo);
            foreach (var itens in carreira1.Itens.OrderBy(x => x.Ordem)) {
                Console.WriteLine($"{itens.Ordem} - {itens.Titulo}");
                Console.WriteLine(itens.Curso?.Titulo);
                Console.WriteLine(itens.Curso?.Nivel);

                foreach (var notificacoes in itens.Notificacoes) {
                    Console.WriteLine($"{notificacoes.Propriedade} - {notificacoes.Mensagem}");
                }
            }
        }

        var paypal = new PayPalAssinatura();
        var estudante = new Estudante();
        estudante.CriarAssinatura(paypal);
    }
}