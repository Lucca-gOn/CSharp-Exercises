// Entrada: Salário recebido e o total gasto;
// Processamento: “Gastos dentro do orçamento” se o valor não ultrapassar o valor do salário; “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

Console.WriteLine($"Informe o salário recebido do mês:");
int salario = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o total gasto no mês:");
int gasto = int.Parse(Console.ReadLine());

int salario = true;
int gasto = false;

 if (salario >= gasto)
 {
     Console.WriteLine($"Gastos dentro do orçamento");    
 }
 else
 {
     Console.WriteLine($"Orçamento estourado");    
 }




