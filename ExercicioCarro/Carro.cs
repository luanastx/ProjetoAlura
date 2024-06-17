class Carro
{
    public int ano;
    public int velocidade = 0;
    public string modelo;

    public void Acelera()
    {
        Console.WriteLine("acelerando...");
        if (velocidade < 100)
        {
            velocidade = velocidade + 10;
        }
    }

    public void Freando()
    {
        Console.WriteLine("freando...");
        if (velocidade > 0)
        {
            velocidade -= 10;
        }
    }

    public void Buzinar()
    {
        Console.WriteLine("Bip Bip");
    }
}