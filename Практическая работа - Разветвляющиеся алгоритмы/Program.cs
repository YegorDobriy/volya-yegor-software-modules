namespace лаба12_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=== Задание 1 ===");
            Console.Write("Введите любое число (можно дробное): ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double result1 = (num1 < 0) ? 0 : num1;
            Console.WriteLine($"Результат обработки: {result1}\n");



            Console.WriteLine("=== Задание 2 ===");
            Console.Write("Введите коэффициент a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double D = Math.Pow(b, 2) - 4 * a * c;
            int rootsCount;
            if (D > 0) { rootsCount = 2; }
            else if (D == 0) { rootsCount = 1; }
            else { rootsCount = 0; }
            Console.WriteLine($"Дискриминант D = {D}");
            Console.WriteLine($"Количество действительных корней: {rootsCount}\n");



            Console.WriteLine("=== Задание 3 ===");
            Console.Write("Введите первое число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите операцию: 1 — (+), 2 — (-), 3 — (*), 4 — (/)");
            Console.Write("Ваш выбор (1-4): ");
            int operation = Convert.ToInt32(Console.ReadLine());
            double calcRes;
            switch (operation)
            {
                case 1: calcRes = x + y; Console.WriteLine($"Результат сложения: {x} + {y} = {calcRes}"); break;
                case 2: calcRes = x - y; Console.WriteLine($"Результат вычитания: {x} - {y} = {calcRes}"); break;
                case 3: calcRes = x * y; Console.WriteLine($"Результат умножения: {x} * {y} = {calcRes}"); break;
                case 4:
                    if (y != 0) { calcRes = x / y; Console.WriteLine($"Результат деления: {x} / {y} = {calcRes}"); }
                    else { Console.WriteLine("Ошибка: Деление на ноль невозможно!"); }
                    break;
                default: Console.WriteLine("Ошибка: Вы ввели неверный номер операции!"); break;
            }
            Console.WriteLine();



            Console.WriteLine("=== Задание 4 ===");
            Console.Write("Введите целое число: ");
            int checkNum = Convert.ToInt32(Console.ReadLine());
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
