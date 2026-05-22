List<int> Numeros = new List<int>();

Numeros.Add(10);
Numeros.Add(20);
Numeros.Add(30);
Numeros.Add(40);
Numeros.Add(50);
Numeros.Add(60);

Numeros.Remove(60);

Numeros.Sort();
Numeros.Reverse();
Console.WriteLine("Contagem dos numeros" +  Numeros.Count);

foreach (int numero in Numeros)
{
    Console.WriteLine(numero);

}

void ValorTotal()
{
    

}