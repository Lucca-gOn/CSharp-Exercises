// Entrada: Placar do jogo, time 1 e time 2;
// Processamento: Informar se o resultado foi empate, se a vitoria foi do primeiro time ou do segundo.

Console.WriteLine($"Informe a quantidade de gols do time 1:");
int time1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe a quantidade de gols do time 2:");
int time2 = int.Parse(Console.ReadLine());

 if (time1 > time2)
 {
     Console.WriteLine($"Vitoria do primeiro time. Parabens!");    
 }
 else if (time1 < time2)
 {
     Console.WriteLine($"Vitoria do segundo time. Parabens!");    
 }
 else if (time1 == time2)
 {
     Console.WriteLine($"Empate");    
 }

