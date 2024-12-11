namespace Random_library;

public class Lines
{
    public static string rand_line(int length)
    {
        string symbol = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*№?";

        char[] line = new char[length];

        for (int i = 0; i < length; i++)
        {
            int rand_index = Numbers.rand_num() % symbol.Length;
            line[i] = symbol[rand_index];
        }

        return new string(line);
    }
}
