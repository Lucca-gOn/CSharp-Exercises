// Entrada: Medidas dos lados do triângulo, medida A, medida B e medida C;
// Processamento: Equilátero 3 lados iguais, Isóscele 2 lados iguais e Escaleno 3 lados diferentes.

Console.WriteLine(@$"
| ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡  ≡|
|                                           |
|     Programa                              |
|     para saber se o triângulo             |
|     é equilátero, isóscele ou escaleno    |
|                                           |
| ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ ≡ |
");

Console.Write($"Informe a medida A do triângulo: ");
int ladoA = int.Parse(Console.ReadLine());

Console.Write($"Informe a medida B do triângulo: ");
int ladoB = int.Parse(Console.ReadLine());

Console.Write($"Informe a medida C do triângulo: ");
int ladoC = int.Parse(Console.ReadLine());

if (ladoA == ladoB && ladoB == ladoC)
{
    Console.WriteLine($"Equilátero");    
}
else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
{
    Console.WriteLine($"Isócele");    
}
else
{
    Console.WriteLine($"Escaleno");    
}


