// Entrada: Notas e frequencia em %;
// Processamento: frequencia <75 reprovado, media >=7 aprovado, media <=3 recuperação.

Console.WriteLine(@$"
| ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ |
|                               |
|     Programa                  |
|     para saber se aluno foi   |
|     aprovado ou reprovado por |
|     frequencia e media        |
|                               |
| ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ |
");

Console.WriteLine($"Informe a média de notas do aluno: ");
float media = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a frequencia do aluno em (%): ");
float frequencia = float.Parse(Console.ReadLine());

if (frequencia < 75)
{
    Console.WriteLine("Aluno reprovado por frequência insuficiente, estude mais!");
}
else if (media >= 7)
{
    Console.WriteLine("Aluno aprovado, parabens!");
}
else if (media <= 3)
{
    Console.WriteLine("Aluno de recuperação, estude mais!");
}
else
{
    Console.WriteLine("Aluno reprovado por média insuficiente");
}
