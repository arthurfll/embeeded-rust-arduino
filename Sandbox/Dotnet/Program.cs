Console.WriteLine("?");

string foo;
var resposta = Console.ReadLine();


if (resposta != null)
{
  foo = resposta;
} else { foo = "nuloo"; }

Console.WriteLine($"Resposta:{foo}");

