Console.WriteLine("------- Bem vindo! -------");
Console.WriteLine("Este programa irá te ajudar a encontrar os multiplos de um determinado número, vamos começar?");
Console.WriteLine();

Console.Write("Digite um número.............: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Avaliar se é multiplo de.....: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 % n2 ==0)
{
    Console.WriteLine($"\n{n1} é multiplo de {n2}");
}
else 
{
    Console.WriteLine($"\n{n1} não é multiplo de {n2}");
}