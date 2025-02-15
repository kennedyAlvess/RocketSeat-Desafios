class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número: ");
        var num1 = Console.ReadLine();
        Console.WriteLine("Informe outro número: ");
        var num2 = Console.ReadLine();

        var numeros = ValidarNumero(num1, num2);

        if (numeros.Item1 is null || numeros.Item2 is null)
        {
            Console.WriteLine("Por favor, informe números válidos.");
            return;
        }

        Console.WriteLine($"Soma: {Soma(numeros.Item1.Value, numeros.Item2.Value)}");
        Console.WriteLine($"Subtração: {Subtracao(numeros.Item1.Value, numeros.Item2.Value)}");
        Console.WriteLine($"Multiplicação: {Multiplicacao(numeros.Item1.Value, numeros.Item2.Value)}");
        Console.WriteLine($"Média: {Media(numeros.Item1.Value, numeros.Item2.Value)}");

        if (numeros.Item2.Value == 0)
            Console.WriteLine("Não é possível dividir por zero.");
        else
            Console.WriteLine($"Divisão: {Divisao(numeros.Item1.Value, numeros.Item2.Value)}");
    }

    public static double Soma(double num1, double num2) => num1 + num2;
    public static double Subtracao(double num1, double num2) => num1 - num2;
    public static double Multiplicacao(double num1, double num2) => num1 * num2;
    public static double Divisao(double num1, double num2) => num1 / num2;
    public static double Media(double num1, double num2) => (num1 + num2) / 2;

    public static (double?, double?) ValidarNumero(string num1, string num2)
    {
        if (!double.TryParse(num1, out double numero1) || !double.TryParse(num2, out double numero2))
        {
            return (null, null);
        }
        return (numero1, numero2);
    }
}