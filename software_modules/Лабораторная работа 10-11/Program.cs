namespace laba10_11Volya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Задание 1===");
            double a1 = 1, a2 = 2, a3 = 3;
            double b1 = 4, b2 = 5, b3 = 6;
            double koef1 = 2, koef2 = 0.5;
            double c1 = koef1 * a1 + koef2 * b1;
            double c2 = koef1 * a2 + koef2 * b2;
            double c3 = koef1 * a3 + koef2 * b3;
            double lenght = Math.Sqrt(Math.Pow(c1, 2) + Math.Pow(c2, 2) + Math.Pow(c3, 2));
            Console.WriteLine($"Вектор c: ({c1}, {c2}, {c3})");
            Console.WriteLine($"Длина вектора c: {lenght}");




            Console.WriteLine("===Задание 2===");
            double q1 = 1, q2 = 2, q3 = 3;
            double k1 = 0.5, k2 = 1.5, k3 = 2.5;
            double S = q1 * k1 + q2 * k2 + q3 * k3;
            double A = S / Math.Sqrt(3);
            Console.WriteLine($"S = {S}");
            Console.WriteLine($"A = {A}");




            Console.WriteLine("===Задание 3===");
            double Tin = 1500;
            double Tout = 500;
            double Cin = 2.5;
            double Cout = 10;
            double CostIn = Tin * Cin / 1000000;
            double CostOut = Tout * Cout / 1000000;
            double Cost = CostIn + CostOut;
            Console.WriteLine($"CostIn = {CostIn}");
            Console.WriteLine($"CostOut = {CostOut}");
            Console.WriteLine($"Cost = {Cost}");
        }
    }
}
