namespace Fundamentos.TiposDeDados;

public static class PontoFlutuante
{
    public static void Executar()
    {
        // Tipos de ponto flutuante
        Console.WriteLine("Tipos de ponto flutuante");
        float valorFloat = 3.14f; // 32 bits
        double valorDouble = 3.14; // 64 bits
        decimal valorDecimal = 3.14m; // 128 bits

        // Exemplo de uso
        Console.WriteLine($"Valor de float: {valorFloat}");
        Console.WriteLine($"Valor de double: {valorDouble}");
        Console.WriteLine($"Valor de decimal: {valorDecimal}");
    }
}