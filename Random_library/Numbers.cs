namespace Random_library;

public class Numbers
{
    private static Random random = new Random();

    public static int rand_num()
    {
        return random.Next();
    }

    public static int rand_num(int min, int max)
    {
        if (min > max)
        {
            int shift = min;
            min = max;
            max = shift;
        }

        return random.Next(min, max + 1);
    }
}
