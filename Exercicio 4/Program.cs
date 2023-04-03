// Entrada: Senha usuario;
// Processamento: ACESSO PERMITIDO com senha válida a 1234 e ACESSO NEGADO com outro tipo de senha;

Console.WriteLine(@$"
| ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡|
|                              |
|     Programa                 |
|     para dar acesso          |
|     com senha de 4 digitos   |
|                              |
| ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡|
");

Console.Write($"Informe a senha de usuário: ");
int senha = int.Parse(Console.ReadLine());

if (senha == 1234)
{
    Console.WriteLine($"ACESSO PERMITIDO");    
}
else 
{
    Console.WriteLine($"ACESSO NEGADO");
}