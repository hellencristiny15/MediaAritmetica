double nota1, nota2, nota3, media;

Console.WriteLine("Media Aritimética de 3 números\n");

Console.Write("Digite a primeira nota...: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a segunda nota....: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a terceira nota...: ");
nota3 = Convert.ToDouble(Console.ReadLine());

media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine($"\nA média:  {media:N1}");