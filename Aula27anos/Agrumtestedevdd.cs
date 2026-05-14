string nome1 = "Andrew";
int idade1 = 26;
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


bool LuzCozinha  = true;
bool LuzSala  = true;


if (LuzCozinha&&LuzSala) 

{
    
    Console.WriteLine ("As luzes estão acessas");
    
}

else

{
    
Console.WriteLine ("As luzes estão apagadas");

}    

bool Levantar = true;
bool Abaixar = false;


void Movimentação (bool Levantar, bool Abaixar)

{

if (Levantar)

Console.WriteLine ("Levantando vidro");


else if (Abaixar)

Console.WriteLine ("Abaixando vidro");

}

Movimentação (Abaixar,Levantar);
