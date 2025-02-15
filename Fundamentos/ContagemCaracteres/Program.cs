
Console.WriteLine("Digite o texto:");

var texto = Console.ReadLine();

Console.WriteLine($"O texto informado possui {texto.Count(c => !char.IsWhiteSpace(c))} caracteres.");