

Console.WriteLine("Informe uma data: ");
var data = Console.ReadLine();

if(DateTime.TryParse(data, out var dataConvertida))
{
    Console.WriteLine($"Dia: {dataConvertida.Day}, Mês: {dataConvertida.Month}, Ano: {dataConvertida.Year}, Hora: {dataConvertida.Hour}, Minuto: {dataConvertida.Minute}, Segundo: {dataConvertida.Second}");
    Console.WriteLine($"{dataConvertida.ToString("dd/MM/yyyy")}");
    Console.WriteLine($"{dataConvertida.ToString("HH:mm:ss")}");
    Console.WriteLine($"{dataConvertida.Day} de {dataConvertida.ToString("MMMM")} de {dataConvertida.Year}");
}
else
{
    Console.WriteLine("Data inválida");
}

