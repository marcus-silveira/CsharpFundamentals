namespace Fundamentos.TiposDeDados;

public static class Inteiros
{
    public static void Executar()
    {
        // Tipos de inteiros
        Console.WriteLine("Tipos de inteiros");
        sbyte valorSbyte = 127; // 8 bits
        byte valorByte = 255; // 8 bits
        short valorShort = 32767; // 16 bits
        ushort valorUshort = 65535; // 16 bits
        int valorInt = 2147483647; // 32 bits
        uint valorUint = 4294967295; // 32 bits
        long valorLong = 9223372036854775807; // 64 bits
        ulong valorUlong = 18446744073709551615; // 64 bits

        // Exemplo de uso
        Console.WriteLine($"Valor de sbyte: {valorSbyte}");
        Console.WriteLine($"Valor de byte: {valorByte}");
        Console.WriteLine($"Valor de short: {valorShort}");
        Console.WriteLine($"Valor de ushort: {valorUshort}");
        Console.WriteLine($"Valor de int: {valorInt}");
        Console.WriteLine($"Valor de uint: {valorUint}");
        Console.WriteLine($"Valor de long: {valorLong}");
        Console.WriteLine($"Valor de ulong: {valorUlong}");
    }
}