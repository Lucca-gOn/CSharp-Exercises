// Entrada: Salário recebido e o total gasto;
// Processamento: gasto <= salario (Dentro do orçamento).

Console.WriteLine(@$"
| ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡  ≡|
|                       |
|     Programa          |
|     para calcular     |
|     orçamento         |
|                       |
| ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ |
");

Console.Write($"Informe o salário recebido do mês:");
float salario = float.Parse(Console.ReadLine());

Console.Write($"Informe o total gasto no mês:");
float gasto = float.Parse(Console.ReadLine());

if (gasto <= salario)
{
    Console.WriteLine($"Gastos dentro do orçamento, permitido SEXTAR!");    
}
else
{
    Console.WriteLine($"Orçamento estourado, bora economizar?");    
}




