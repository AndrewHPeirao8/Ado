using System.Globalization;

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


   string[] vagas = new string[10];
   vagas[0] = "Carro do João";
   vagas[1] = "Moto da Maria";

 List<string> compras = new List<string> { "Arroz", "Feijão" };
   compras.Add("Leite");
   compras.Add("Pão");

   Dictionary<string, string> agenda = new Dictionary<string, string>
   {
       { "Maria", "(11) 99999-0001" },
       { "João", "(11) 99999-0002" }
   };
   string telefone = agenda["Maria"]; // (11) 99999-0001



   List<string> Nomes = new List<string>();

   Nomes.Add ("Andrew");
   Nomes.Add ("Renata");

   foreach (string nome in Nomes)

   Console.WriteLine(nome);

   Dictionary<string, string> Chamada = new Dictionary<string, string>
   {
       { "01", "Andrew" },
       { "02", "Renata" }
   };

