
class Musica
{
    private int duracao;
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }

    public bool Disponivel { get; set; }

    public string DescricaoResumida =>
        $"A musica {Nome} pertence a o artista {Artista}";

    public void ExibirFichaMusica()
    {
        Console.WriteLine($"nome: {Nome}");
        Console.WriteLine($"artista: {Artista}");
        Console.WriteLine($"duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("disponivel");
        }
        else
        {
            Console.WriteLine("apenas disponivel no plano plus+");
        }
    }
}
