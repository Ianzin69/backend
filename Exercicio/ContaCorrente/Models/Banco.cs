namespace Models
{
    public ContaCorrente
    {
        public ContaCorrente(string titular)
    {
        this.titular = titular;
    }
    private string titular { get; set; }
    private decimal saldo { get; set; }


    public Conta(string titular, decimal saldo)
    {
        this.titular = titular;
        this.saldo = saldo;
    }

    public void ConsultarSaldo()
    {
        Console.WriteLine($"seu saldo atual é:{saldo}")
        }

    public void Depositar(double deposito)
    {
        Console.WriteLine("Qual será o valor depositado?");
        deposito = double.Parse(Console.Readline());
        if (deposito > 0)
        {
            saldo += deposito;
        }
        else
        {
            Console.WriteLine("Seu deposito é invalido")
        }
    }

    public void Sacar(double)
    {
        Console.WriteLine("Qual será o valor sacado?");
        double subtracao = 0
        saque = double.Parse(Console.Readline());
        if (saque > 0)
        {
            subtracao = saldo - saque;
            Console.WriteLine($"saque é de {saque}, o saldo atual é de {subtracao}")
        }
        else
        {
            Console.WriteLine("Seu saque é alem do saldo")

        }

    }
}