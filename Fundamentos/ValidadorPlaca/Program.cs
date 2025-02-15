
class Program
{
    static void Main()
    {
        Console.WriteLine("Informe a placa do veículo no padrão XXX0000: ");
        var placa = Console.ReadLine();

        Console.WriteLine(ValidarPlaca(placa));
    }

    public static bool ValidarPlaca(string placa)
    {
        bool totalCaractere = placa.Replace(" ", "").Replace("-","").Length == 7;

        string letras = placa.Substring(0, 3);
        string numeros = placa.Substring(3, 4);

        bool tresLetras = letras.All(char.IsLetter);
        bool quatroNumeros = numeros.All(char.IsDigit);

        return totalCaractere && tresLetras && quatroNumeros;
    }
}