// Entrada: Quantidade de maças?
// Processamento: Quantidade de maças, quantidade maças <12 (0.30) e desconto se for maior que 12.
Console.WriteLine(@$"
| ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ |
|                         |
|     Programa            |
|     para calcular preço |
|     das maças           |
|                         |
| ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ |
");

Console.Write("Digite o número de maçãs compradas: ");
int quantidadeMacas = int.Parse(Console.ReadLine());

// PONTO FLUTUANTE DOUBLE
double precoMacas;

if (quantidadeMacas < 12) 
{
    precoMacas = 0.30;
} 
else 
{
    precoMacas = 0.25;
}

double total = (quantidadeMacas * precoMacas);
Console.WriteLine($"O valor total da compra é de R$ {total}");
