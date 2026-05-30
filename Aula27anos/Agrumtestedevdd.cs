using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Reflection;
using System.Security.Authentication.ExtendedProtection;

string nome1 = "Andrew";
int idade1 = 27;
string nome2 = "Renata";
int idade2 = 25;
Console.WriteLine ($"{nome1} tem {idade1} anos {nome2} tem {idade2}");
if(idade1 >=18 && idade2 >=18);
Console.WriteLine ("os dois tem idade para a festinha");

Console.WriteLine ("o Geovan da muuito é a bunda");

Console.WriteLine("Eu amo muito a Renata");




string Professor1 = "Kairo";
string Professor2 = "Pedro";
string Professor3 = "Lucas";

string Materia1 = "Banco de dados ";
string Materia2 = "Git & Github";
string Materia3 = "Ingles Técnico";
string Materia4 = "fundamentos do C#";
string Materia5 = "Empreendorismo";
string Materia6 = "Marketing pessoal"; 

void ChamadaProfessor (String Professor1, string Professor2, String Professor3, string Materia1, string Materia2, string Materia3, String Materia4)

{
    
Console.WriteLine($"Eu tenho o professor {Professor1} que da as materias {Materia1} e a materia {Materia2} tenho o professor {Professor2} que da a materia {Materia3} e a materia {Materia4}");

}

ChamadaProfessor (Professor1,Professor2, Professor3, Materia1, Materia2, Materia3, Materia4);


bool LuzCozinha  = !true;
bool LuzSala  = !true;

if (LuzCozinha&&LuzSala) 

{
    Console.WriteLine ("As luzes estão acessas");
}

else if (!LuzCozinha&&!LuzSala)

{  
Console.WriteLine ("As luzes estão apagadas");
}    





bool Levantar = true;
bool Abaixar = false;

void Movimentação (bool Levantar,bool Abaixar)

{

if (Levantar)

Console.WriteLine ("Levantando vidro");

else if (Abaixar)

Console.WriteLine ("Abaixando vidro");

}

Movimentação (Abaixar,Levantar);



int Numero = 8;

int Resultado = SomarMaisDois(Numero);

Console.WriteLine($"Resultado={Resultado}");

int SomarMaisDois (int valor)

{
    
return valor +2;

}

  void ExibirDataAtual()
{
    Console.WriteLine(DateTime.Now.ToShortDateString());
}
 ExibirDataAtual();


List<string> Chamada = new List<string>();

Chamada.Add("Andrew");
Chamada.Add("Renata");
Chamada.Add("Edevaldo");
Chamada.Add("Adriana");

foreach (string aluno in Chamada)
{
    Console.WriteLine($"{aluno} - Presente");

}

if (Chamada.Contains("Andrew"))
{

    Console.WriteLine("Andrew Presente");    

}

Console.WriteLine(Chamada);

void ListarAlunos(List<string>Chamada)

{
    if (Chamada.Count == 0)
    {
     Console.WriteLine ("Nenhum Aluno Cadastrado");   
     return;

    }

    Console.WriteLine("\n=== Lista de alunos");

    foreach (string aluno in Chamada)

    Console.WriteLine(aluno);

}

List<string> LutasMarciais = new List<string>();

LutasMarciais.Add ("Muay Thai");
LutasMarciais.Add ("Boxe");
LutasMarciais.Add ("Kick Boxe");
LutasMarciais.Add ("Kung Fu");
LutasMarciais.Add ("MMA");

LutasMarciais.Remove ("MMA");

foreach (string Luta in LutasMarciais)

{
    Console.WriteLine(Luta);
}

{   
    Console.WriteLine(LutasMarciais.Count);
}

{
    Console.WriteLine(LutasMarciais[2]);

}


  if (LutasMarciais.Count >=2)

{
    Console.WriteLine("Tem Bastante lutas");
}

List<string> Personagens = new List<string> {"Goku", "Naruto",};

Personagens.Add ("Killua");
Personagens.Add ("Sasuke");
Personagens.Add ("Vegeta");
Personagens.Add ("Gon");
Personagens.Add ("Jiraya");

foreach (string Nomes in Personagens)
{
    Console.WriteLine(Nomes);

}

if (Personagens.Count >=3)
{
Console.WriteLine("Personagem pra baralho");
}

bool CaixaE = true;
bool CaixaD = true;

if (CaixaD && CaixaE)
{
    Console.WriteLine("As Caixinha tao torando");
}

else if (!CaixaD && !CaixaE)
{
    Console.WriteLine("Tamo triste");
}

else if (!CaixaD && CaixaE)
{
    Console.WriteLine("Ainda tem alguma coisa porem muito esquerdista");
}

else 
{
    Console.WriteLine("Tamo melhor que do outro lado kkkkkkkkk");  
}

