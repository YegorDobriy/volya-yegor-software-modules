namespace _20_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taskwgoto();
            Taskwbreak();
            Taskwcontinue();
            Taskwreturn();
        }
        static void Taskwgoto()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double min = a;
            if (b < min)
                min = b;
            if (c < min)
                min = c;
            goto Result;
        Result:
            Console.WriteLine("Минимум = " + min);
        }
        static void Taskwbreak()
        {
            double[] numbers = new double[3];
            for (int i = 0; i < 3; i++)
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            double min = numbers[0];
            for (int i = 1; i < 3; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
                if (i == 2)
                    break;
            }
            Console.WriteLine("Минимум = " + min);
        }
        static void Taskwcontinue()
        {
            double[] numbers = new double[3];
            for (int i = 0; i < 3; i++)
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            double min = numbers[0];
            for (int i = 1; i < 3; i++)
            {
                if (numbers[i] >= min)
                    continue;
                min = numbers[i];
            }
            Console.WriteLine("Минимум = " + min);
        }
        static void Taskwreturn()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double min = FindMin(a, b, c);
            Console.WriteLine("Минимум = " + min);
        }
        static double FindMin(double a, double b, double c)
        {
            double min = a;
            if (b < min)
                min = b;
            if (c < min)
                min = c;
            return min;
        }
    }
}
