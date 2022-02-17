public class HW1
{
    public static long QueueTime(int[] customers, int s, int c)
    {
        if (c == 1)
        {
            long sum = 0;
            for (int i = 0; i < s; ++i)
            {
                sum += customers[i];
            }
            return sum;
        }
        else
        {
            int[] kassa = new int[c];
            for (int i = 0; i < c; ++i)
            {
                kassa[i] = 0;
            }
            for (int i = 0; i < s; ++i)
            {
                int min = 999;
                int ind = 0;
                for (int j = 0; j < c; ++j)
                {                                   
                    if (kassa[j] < min)
                    {
                        min = kassa[j];
                        ind = j;
                    }
                }
                kassa[ind] += customers[i];
            }
            long max = 0;
            for (int i = 0; i < c; ++i)
            {
                if (kassa[i] > max)
                {
                    max = kassa[i];
                }

            }
            return max;
        }
    }


    public class Programm
    {
        static void Main()
        {
            int[] cassa1 = { 5, 3, 4 };
            int[] cassa2 = { 10, 2, 3, 3 };
            int[] cassa3 = { 2, 3, 10 };
            int[] cassa4 = { 10, 5, 6, 7 };
            int a = 1;
            int b = 2;
            Console.WriteLine(QueueTime(cassa1, 3, a));
            Console.WriteLine(QueueTime(cassa2, 4, b));
            Console.WriteLine(QueueTime(cassa3, 3, b));
            Console.WriteLine(QueueTime(cassa4, 4, b));
        }

    }
}
