using System;

List<int> inteiros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

void pares()
{
    Console.WriteLine("com for");
    for (int i = 0; i < inteiros.Count; i++)
    {
        if (inteiros[i] % 2 == 0)
        {
            Console.WriteLine(inteiros[i]);
        }

    }
    Console.WriteLine("\n com foreach");

    foreach (int numero in inteiros)
    {

        if (numero % 2 == 0)
        {
            Console.WriteLine(numero);
        }
    }

}
pares();