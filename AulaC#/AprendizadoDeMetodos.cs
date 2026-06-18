int Calculadora (int a, int b)
{
    int resultado = a + b;
    return resultado;
}

Calculadora(5, 10);

Console.WriteLine(Calculadora(5, 10));

double CalculadoraMedia (int a, int b)
{
    double resultado = (a+b)/2.0;
    return resultado;
}

Console.WriteLine(CalculadoraMedia(5, 10));

void ImprimirMensagem (string mensagem)
{
    Console.WriteLine(mensagem);
}

ImprimirMensagem("Teste de mensagem");


double SomaDosMetodos (int calculadora, double calculadoraMedia)
{
    double resultado = calculadora + calculadoraMedia;
    return resultado;
}

Console.WriteLine(SomaDosMetodos(Calculadora(5, 10), (double)CalculadoraMedia(5, 10)));

Console.WriteLine((Calculadora(5, 10) + CalculadoraMedia(5, 10))/2.0);

list<int> NumerosPares = new List<int>{2, 4, 6, 8, 10};

foreach (int numero in NumerosPares)
{
    Console.WriteLine(numero);
}