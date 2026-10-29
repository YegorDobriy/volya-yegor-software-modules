namespace lab16_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;



            Console.WriteLine("Общее упражнение №1 (Чтение до маркера 0)");
            long sum = 0;
            int count = 0;
            Console.WriteLine("Вводите целые числа; 0 завершает ввод.");
            input = Console.ReadLine();
            if (input == null) { Console.WriteLine("Ввод завершён"); return; }
            int value = int.Parse(input);
            while (value != 0)
            {
                sum += value;
                count++;
                input = Console.ReadLine();
                if (input == null) { Console.WriteLine("Ввод завершён"); return; }
                value = int.Parse(input);
            }
            Console.WriteLine($"Количество: {count}; сумма: {sum}");



            Console.WriteLine("Общее упражнение №2 (Увеличение буфера)");
            long capacity1 = 1; int steps1 = 0;
            while (capacity1 < 1) { capacity1 *= 2; steps1++; }
            Console.WriteLine($"Для N = 1 -> Результат емкости: {capacity1}; Шагов: {steps1}");
            long capacity7 = 1; int steps7 = 0;
            while (capacity7 < 7) { capacity7 *= 2; steps7++; }
            Console.WriteLine($"Для N = 7 -> Результат емкости: {capacity7}; Шагов: {steps7}");
            long capacity8 = 1; int steps8 = 0;
            while (capacity8 < 8) { capacity8 *= 2; steps8++; }
            Console.WriteLine($"Для N = 8 -> Результат емкости: {capacity8}; Шагов: {steps8}");



            Console.WriteLine("Общее упражнение №3 (Поиск первого отрицательного)");
            int[] arr1 = new int[0];
            int idx1 = 0;
            while (idx1 < arr1.Length && arr1[idx1] >= 0) { idx1++; }
            Console.WriteLine("Массив []: " + (idx1 < arr1.Length ? $"Индекс {idx1}" : "Не найдено"));
            int[] arr2 = new int[] { -1 };
            int idx2 = 0;
            while (idx2 < arr2.Length && arr2[idx2] >= 0) { idx2++; }
            Console.WriteLine("Массив [-1]: " + (idx2 < arr2.Length ? $"Индекс {idx2}" : "Не найдено"));
            int[] arr3 = new int[] { 2, 3 };
            int idx3 = 0;
            while (idx3 < arr3.Length && arr3[idx3] >= 0) { idx3++; }
            Console.WriteLine("Массив [2, 3]: " + (idx3 < arr3.Length ? $"Индекс {idx3}" : "Не найдено"));
            int[] arr4 = new int[] { 2, -1 };
            int idx4 = 0;
            while (idx4 < arr4.Length && arr4[idx4] >= 0) { idx4++; }
            Console.WriteLine("Массив [2, -1]: " + (idx4 < arr4.Length ? $"Индекс {idx4}" : "Не найдено"));



            Console.WriteLine("Вариант 5. Задание А (Квадраты положительных чисел <= N)");
            Console.Write("Введите целое число N (0..1000000): ");
            input = Console.ReadLine();
            if (input == null) { Console.WriteLine("Ввод завершён"); return; }
            int limitN = int.Parse(input);
            long current = 1;
            while (current * current <= limitN)
            {
                Console.WriteLine($"Число: {current}, его квадрат: {current * current}");
                current++;
            }
            if (current == 1)
            {
                Console.WriteLine("Нет подходящих квадратов положительных чисел.");
            }



            Console.WriteLine("5. Задание Б (Перечисление возможных площадей плит)");
            Console.Write("Введите бюджет площади N (0..1000000): ");
            input = Console.ReadLine();
            if (input == null) { Console.WriteLine("Ввод завершён"); return; }
            int budgetN = int.Parse(input);
            long side = 1;
            bool found = false;
            while (side * side <= budgetN)
            {
                Console.WriteLine($"Сторона плитки: {side}, Возможная площадь: {side * side}");
                side++;
                found = true;
            }
            if (!found)
            {
                Console.WriteLine("При N = 0 вариантов нет.");
            }

        }
    }
}
