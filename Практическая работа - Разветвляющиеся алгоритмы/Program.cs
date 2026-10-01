namespace лаба12_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Задание 4 ===");
            Console.Write("Введите целое число: ");
            int checkNum = int.Parse(Console.ReadLine());
            string desc = checkNum switch
            {
                >= 1 and <= 9 => "Однозначное положительное число",
                >= 10 and <= 99 => "Двузначное положительное число",
                >= 100 and <= 999 => "Трёхзначное положительное число",
                _ => "Другое число (отрицательное, ноль или многозначное)"
            };
            Console.WriteLine($"Категория числа: {desc}\n");
        }
    }
}
