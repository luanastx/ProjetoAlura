class Conta
{
    public int numeroind;
    public string titular;
    public float saldo;
    public int senha;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"titular: {titular}");
        Console.WriteLine($"numero: {numeroind}");
        Console.WriteLine($"saldo: {saldo}");
        Console.WriteLine($"senha: {senha}");

    }

}