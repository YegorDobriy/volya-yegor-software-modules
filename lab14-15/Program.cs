using System;

namespace lab14_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string answer;


            Console.WriteLine("Общее упражнение №1 (Проверка размера группы)");
            int size;
            bool valid;
            do
            {
                Console.Write("Количество участников (1–30): ");
                input = Console.ReadLine();
                if (input == null) { Console.WriteLine("Ввод завершён"); return; }
                valid = int.TryParse(input, out size) && size >= 1 && size <= 30;
                if (!valid)
                    Console.WriteLine("Нужно целое число от 1 до 30.");
            }
            while (!valid);
            Console.WriteLine($"Принято: {size}");



            Console.WriteLine("Общее упражнение №2 (Подсчет цифр: 0, 7, 1000)");
            int[] testNumbers = { 0, 7, 1000 };
            foreach (int originalN in testNumbers)
            {
                int remaining = Math.Abs(originalN);
                int count = 0;
                do
                {
                    count++;
                    remaining /= 10;
                }
                while (remaining > 0);
                Console.WriteLine($"Число: {originalN}, Количество цифр: {count}");
            }



            Console.WriteLine("Общее упражнение №3 (Диалог с приветствием)");
            do
            {
                Console.WriteLine("Приветствуем вас!");
                Console.Write("Повторить приветствие? (д/н): ");
                answer = Console.ReadLine();
                if (answer == null) { Console.WriteLine("Ввод завершён"); return; }
            }
            while (string.Equals(answer, "д", StringComparison.OrdinalIgnoreCase));



            Console.WriteLine("Вариант 5. Задание А (Сложение двух чисел от -1000 до 1000)");
            do
            {
                int a, b;
                bool validA, validB;
                do
                {
                    Console.Write("Введите первое число (-1000..1000): ");
                    input = Console.ReadLine();
                    if (input == null) { Console.WriteLine("Ввод завершён"); return; }
                    validA = int.TryParse(input, out a) && a >= -1000 && a <= 1000;
                    if (!validA) Console.WriteLine("Ошибка! Нужно целое число от -1000 до 1000.");
                } while (!validA);
                do
                {
                    Console.Write("Введите второе число (-1000..1000): ");
                    input = Console.ReadLine();
                    if (input == null) { Console.WriteLine("Ввод завершён"); return; }
                    validB = int.TryParse(input, out b) && b >= -1000 && b <= 1000;
                    if (!validB) Console.WriteLine("Ошибка! Нужно целое число от -1000 до 1000.");
                } while (!validB);
                Console.WriteLine($"Результат сложения: {(long)a + b}");
                Console.Write("Повторить расчет сложения? (д/н): ");
                answer = Console.ReadLine();
                if (answer == null) { Console.WriteLine("Ввод завершён"); return; }
            }
            while (string.Equals(answer, "д", StringComparison.OrdinalIgnoreCase));



            Console.WriteLine("Вариант 5. Задание Б (Расчет площади прямоугольника)");
            do
            {
                double width, height;
                bool validW, validH;
                do
                {
                    Console.Write("Введите ширину (0.1..1000): ");
                    input = Console.ReadLine();
                    if (input == null) { Console.WriteLine("Ввод завершён"); return; }
                    input = input.Replace('.', ',');
                    validW = double.TryParse(input, out width) && width >= 0.1 && width <= 1000.0;
                    if (!validW) Console.WriteLine("Ошибка! Нужно число от 0.1 до 1000.");
                } while (!validW);
                do
                {
                    Console.Write("Введите высоту (0.1..1000): ");
                    input = Console.ReadLine();
                    if (input == null) { Console.WriteLine("Ввод завершён"); return; }
                    input = input.Replace('.', ',');
                    validH = double.TryParse(input, out height) && height >= 0.1 && height <= 1000.0;
                    if (!validH) Console.WriteLine("Ошибка! Нужно число от 0.1 до 1000.");
                } while (!validH);
                Console.WriteLine($"Площадь прямоугольника: {width * height}");
                Console.Write("Нужен еще один расчет площади? (д/н): ");
                answer = Console.ReadLine();
                if (answer == null) { Console.WriteLine("Ввод завершён"); return; }
            }
            while (string.Equals(answer, "д", StringComparison.OrdinalIgnoreCase));
        }
    }
}
