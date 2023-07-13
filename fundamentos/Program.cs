class Program {
    static void RealizandoPagamento(decimal valor){
        Console.WriteLine($"Pagando {valor} ao seu amigo :)");
    }

    static void Main(string[] args) {
        var pagamento01 = new Pagamento(75, "Bradesco", 1);
        var pagamento02 = new Pagamento(75, "Caixa", 3);

        // Console.WriteLine(pagamento01.Equals(pagamento02));

        // var pagar = new Pagamento.Pagar(RealizandoPagamento);

        var contexto = new ContextoDados<Pagamento, Assinatura, Pessoa>();

        contexto.Salvar(pagamento02);
        pagamento01.EventoMaximoDeSaques += AoAlcancarLimiteDeSaques;
        pagamento01.Sacar(20);
        pagamento01.Sacar(30);
        pagamento01.Sacar(40);

        var pagamentos = new List<Pagamento>();
        pagamentos.Add(pagamento01);
        pagamentos.Add(pagamento02);

        IEnumerable<Pagamento> payment = pagamentos.AsEnumerable();

        Console.WriteLine(pagamentos.Any(x => x.Valor > 75));

        foreach (var item in pagamentos){
            Console.WriteLine(item);
        }
    }

    static void AoAlcancarLimiteDeSaques(object? sender, EventArgs e) {
        Console.WriteLine("Limite de quantidade de saques diários alcançado");
    }
}

class ContextoDados<PA, A, P> 
    where PA : Pagamento
    where A : Assinatura
    where P: Pessoa
{
    public void Salvar(PA entidade){

    }

    public void Salvar(A entidade) {

    }

    public void Salvar(P entidade) {

    }
}

class Assinatura {
    
}

class Pessoa {
    
}

class Pagamento : IEquatable<Pagamento> {
    public Pagamento(decimal valor, string banco, int limitedesaques){
        Valor = valor;
        Banco = banco;
        LimiteDeSaques = limitedesaques;
    }
    public decimal Valor { get; set; }
    public string? Banco { get; set; }

    private int Saques = 0;

    private int LimiteDeSaques;

    public void Sacar(decimal valor){
        Saques++;
        if (Saques > LimiteDeSaques){
            AoAlcancarLimiteDeSaques(EventArgs.Empty);
            // Console.WriteLine("Limite de quantidade de saques diários alcançado");
        } else {
            Console.WriteLine($"Saque de R${valor} realizado com sucesso");
        }
    }

    public event EventHandler? EventoMaximoDeSaques;

    protected virtual void AoAlcancarLimiteDeSaques(EventArgs e){
        EventHandler? handler = EventoMaximoDeSaques;
        handler?.Invoke(this, e);
    } 

    public delegate void Pagar(decimal valor);

    public bool Equals(Pagamento? pagamento)
    {
        return this.Valor == pagamento?.Valor && this.Banco == pagamento.Banco; 
    }
}

