using Random_library;

class Test
{
    static void Main()
    {
        Console.WriteLine($"Случайное число: {Numbers.rand_num()}, " +
            $"Случайное число в диапазоне от 0-20: {Numbers.rand_num(20, 0)}"); // я намерено написала от 20-0 в вызове метода, потому что ее функционал это позволяет

        Console.WriteLine($"Случайная строка: {Lines.rand_line(10)}");
    }
}
