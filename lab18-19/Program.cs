namespace lab18_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            TaskA1();
            TaskB1();
            TaskA2();
            TaskB2();
        }
        static void Task1()
        {
            char[] alphabet = new char[26];
            for (int i = 0; i < alphabet.Length; i++)
                alphabet[i] = (char)('A' + i);
            foreach (char letter in alphabet)
                Console.Write(letter + " ");
            Console.WriteLine();
        }
        static void Task2()
        {
            char[] alphabet = new char[33];
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (i < 6)
                    alphabet[i] = (char)('А' + i);
                else if (i == 6)
                    alphabet[i] = 'Ё';
                else
                    alphabet[i] = (char)('А' + i - 1);
            }
            foreach (char letter in alphabet)
                Console.Write(letter + " ");
            Console.WriteLine();
        }
        static void Task3()
        {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"Сумма элементов: {sum}");
        }
        static void Task4()
        {
            string[] sourceArray = { "привет", "", "уфа", "   ", "c#", null, "круто" };
            List<string> nonEmptyList = new List<string>();
            foreach (string str in sourceArray)
            {
                if (!string.IsNullOrWhiteSpace(str))
                {
                    nonEmptyList.Add(str);
                }
            }
            Console.WriteLine("Непустые строки в новом списке:");
            foreach (string item in nonEmptyList)
            {
                Console.WriteLine(item);
            }
        }
        static void Task5()
        {
            int[] numbers = { 5, 8, 12, 11, 4 };
            Console.WriteLine("Элементы на чётных индексах:");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Индекс [{i}]: значение = {numbers[i]}");
                }
            }
            Console.WriteLine("\nЧётные значения в массиве:");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine($"Найдено чётное значение {numbers[i]} (на индексе [{i}])");
                }
            }
        }
        static void TaskA1()
        {
            Console.Write("Размер массива: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            if (n < 0)
            {
                Console.WriteLine("Размер массива не может быть отрицательным.");
                return;
            }
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Элемент [{i}]: ");
                numbers[i] = int.Parse(Console.ReadLine() ?? "0");
                numbers[i] *= numbers[i];
            }
            Console.Write("Результат: ");
            foreach (int num in numbers)
                Console.Write(num + " ");
            Console.WriteLine();
            if (numbers.Length == 0)
            {
                Console.WriteLine("Массив пуст.");
            }
        }
        static void TaskB1()
        {
            Console.Write("Кол-во температур: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            if (n < 0)
            {
                Console.WriteLine("Количество температур не может быть отрицательным.");
                return;
            }
            int[] temps = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Запись [{i}]: ");
                int val = int.Parse(Console.ReadLine() ?? "0");
                temps[i] = val < 0 ? 0 : val;
            }
            Console.Write("Результат: ");
            foreach (int t in temps)
                Console.Write(t + " ");
            Console.WriteLine();
            // Дополнительная обработка готовых массивов
            int[][] temperatureSets =
            {
                new int[] { -100, -25, 0, 15, -5, 100 },
                new int [] { 10, 20, 30, 40 },
                new int[0]
            };
            Console.WriteLine("\nОбработка готовых наборов температур:");
            foreach (int[] set in temperatureSets)
            {
                for (int i = 0; i < set.Length; i++)
                {
                    if (set[i] < 0)
                        set[i] = 0;
                }
                Console.Write("Готовый набор температур: ");
                if (set.Length == 0)
                {
                    Console.WriteLine("массив пуст");
                }
                else
                {
                    foreach (int temperature in set)
                        Console.Write(temperature + " ");
                    Console.WriteLine();
                }
            }
        }
        static void TaskA2()
        {
            Console.Write("Размер массива: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            if (n <= 0)
            {
                Console.WriteLine("Массив пуст, среднее не определено");
                return;
            }
            double[] numbers = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Число [{i}]: ");
                numbers[i] = double.Parse(Console.ReadLine() ?? "0");
            }
            double sum = 0;
            int count = 0;
            foreach (double num in numbers)
            {
                sum += num;
                count++;
            }
            Console.WriteLine($"Количество: {count}, Среднее: {sum / count}");
            if (count == 0)
            {
                Console.WriteLine("Невозможно вычислить среднее значение для пустого массива.");
            }
        }
        static void TaskB2()
        {
            Console.Write("Кол-во оценок: ");
            int n = int.Parse(Console.ReadLine() ?? "0");
            if (n <= 0)
            {
                Console.WriteLine("Набор оценок пуст. Среднее не определено.");
                return;
            }
            int[] grades = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Оценка [{i}]: ");
                grades[i] = int.Parse(Console.ReadLine() ?? "2");
            }
            double sum = 0;
            foreach (int grade in grades)
                sum += grade;
            Console.WriteLine($"Кол-во: {n}, Ср. оценка: {(sum / n):F2}");
            // Дополнительная обработка готовых наборов оценок
            int[][] gradeSets =
            {
                new int[] { 5, 4, 3, 5, 2 },
                new int[] { 4 },
                new int[0]
            };
            Console.WriteLine("\nОбработка готовых наборов оценок:");
            foreach (int[] set in gradeSets)
            {
                double total = 0;
                int amount = 0;
                foreach (int grade in set)
                {
                    total += grade;
                    amount++;
                }
                if (amount == 0)
                {
                    Console.WriteLine("Готовый набор оценок пуст. Среднее не определено.");
                }
                else
                {
                    Console.WriteLine(
                        $"Готовый набор: количество = {amount}, среднее = {total / amount:F2}");
                }
            }
        }
    }
}
