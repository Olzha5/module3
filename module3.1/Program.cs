////////using System;
////////using System.Linq;

////////class Program
////////{
////////    static void Main()
////////    {
////////        // 1. Напечатать весь массив целых чисел
////////        int[] array = { 1, 2, 3, 4, 5 };
////////        Console.WriteLine("Массив целых чисел:");
////////        foreach (int i in array)
////////        {
////////            Console.WriteLine(i);
////////        }

////////        // 2. Найти индекс максимального значения в массиве
////////        int maxIndex = Array.IndexOf(array, array.Max());
////////        Console.WriteLine($"Индекс максимального значения: {maxIndex}");

////////        // 3. Найти индекс максимального четного значения в массиве
////////        int maxEvenValue = array.Where(x => x % 2 == 0).Max();
////////        int maxEvenIndex = Array.IndexOf(array, maxEvenValue);
////////        Console.WriteLine($"Индекс максимального четного значения: {maxEvenIndex}");

////////        // 4. Удалить элемент из массива по индексу.
////////        Console.WriteLine("Введите индекс для удаления:");
////////        int indexToDelete = Convert.ToInt32(Console.ReadLine());
////////        array = array.Where((val, idx) => idx != indexToDelete).ToArray();
////////        Console.WriteLine("Массив после удаления:");
////////        foreach (int i in array)
////////        {
////////            Console.WriteLine(i);
////////        }

////////        // 5. Удаление элементов из массива по значению
////////        Console.WriteLine("Введите значение для удаления:");
////////        int valueToDelete = Convert.ToInt32(Console.ReadLine());
////////        array = array.Where(val => val != valueToDelete).ToArray();
////////        Console.WriteLine("Массив после удаления по значению:");
////////        foreach (int i in array)
////////        {
////////            Console.WriteLine(i);
////////        }
////////        // 6. Вставить элемент в массив по индексу
////////        Console.WriteLine("Введите значение для вставки:");
////////        int valueToInsert = Convert.ToInt32(Console.ReadLine());
////////        Console.WriteLine("Введите индекс, куда вставить значение:");
////////        int indexToInsert = Convert.ToInt32(Console.ReadLine());
////////        List<int> tempList = array.ToList();
////////        tempList.Insert(indexToInsert, valueToInsert);
////////        array = tempList.ToArray();
////////        Console.WriteLine("Массив после вставки:");
////////        foreach (int i in array)
////////        {
////////            Console.WriteLine(i);
////////        }

////////        // 7. Удалить те элементы массива, которые встречаются в нем ровно два раза
////////        array = array.Where(val => array.Count(x => x == val) != 2).ToArray();
////////        Console.WriteLine("Массив после удаления элементов, встречающихся ровно два раза:");
////////        foreach (int i in array)
////////        {
////////            Console.WriteLine(i);
////////        }

////////        // 8. Удалить из строки слова, в которых есть буква 'a'
////////        Console.WriteLine("Введите строку:");
////////        string inputStr = Console.ReadLine();
////////        string resultStr = string.Join(" ", inputStr.Split(' ').Where(word => !word.Contains('a')));
////////        Console.WriteLine($"Строка после удаления слов с буквой 'a': {resultStr}");

////////        // 9. Удалить из строки слова, в которых есть хоть одна буква последнего слова
////////        char lastWordChar = inputStr.Split(' ').Last().First();
////////        resultStr = string.Join(" ", inputStr.Split(' ').Where(word => !word.Contains(lastWordChar)));
////////        Console.WriteLine($"Строка после удаления слов, содержащих букву '{lastWordChar}' из последнего слова: {resultStr}");

////////        // 10. В строке все слова, которые начинаются и заканчиваются одной буквой, выделить квадратными скобками
////////        resultStr = string.Join(" ", inputStr.Split(' ').Select(word => word.First() == word.Last() ? $"[{word}]" : word));
////////        Console.WriteLine($"Строка после выделения: {resultStr}");

////////        // 11. Обнулить элементы тех строк, на пересечении которых с главной диагональю стоит четный элемент
////////        int[,] matrix =
////////        {
////////            {1, 2, 3},
////////            {4, 5, 6},
////////            {7, 8, 9}
////////        };
////////        for (int i = 0; i < matrix.GetLength(0); i++)
////////        {
////////            if (matrix[i, i] % 2 == 0)
////////            {
////////                for (int j = 0; j < matrix.GetLength(1); j++)
////////                {
////////                    matrix[i, j] = 0;
////////                }
////////            }
////////        }

////////        // 12. Обнулить элементы тех столбцов, на пересечении которых с главной диагональю стоит четный элемент
////////        for (int i = 0; i < matrix.GetLength(1); i++)
////////        {
////////            if (matrix[i, i] % 2 == 0)
////////            {
////////                for (int j = 0; j < matrix.GetLength(0); j++)
////////                {
////////                    matrix[j, i] = 0;
////////                }
////////            }
////////        }

////////        // 13. Удалить те столбцы, в которых встречается хотя бы два одинаковых элемента (решение будет далее)

////////        // 14. Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка...
////////        Console.WriteLine("Введите символы. Для завершения введите точку:");
////////        char ch;
////////        int spaceCount = 0;
////////        do
////////        {
////////            ch = Console.ReadKey().KeyChar;
////////            if (ch == ' ')
////////            {
////////                spaceCount++;
////////            }
////////        } while (ch != '.');
////////        Console.WriteLine($"\nКоличество пробелов: {spaceCount}");

////////        // 15. Проверка счастливого билета
////////        Console.WriteLine("Введите номер трамвайного билета (6-значное число):");
////////        string ticket = Console.ReadLine();
////////        int firstHalf = Convert.ToInt32(ticket.Substring(0, 3).ToCharArray().Sum(c => c - '0'));
////////        int secondHalf = Convert.ToInt32(ticket.Substring(3, 3).ToCharArray().Sum(c => c - '0'));
////////        Console.WriteLine(firstHalf == secondHalf ? "Билет счастливый" : "Билет не счастливый");


////////        // 16. Конвертация символов нижнего регистра в верхний и наоборот
////////        Console.WriteLine("Введите строку для конвертации регистра символов:");
////////        string strInput = Console.ReadLine();
////////        string convertedStr = new string(strInput.Select(ch => char.IsUpper(ch) ? char.ToLower(ch) : char.ToUpper(ch)).ToArray());
////////        Console.WriteLine($"Конвертированная строка: {convertedStr}");

////////        // 17. Число N справа налево
////////        Console.WriteLine("Введите целое число N:");
////////        int n = int.Parse(Console.ReadLine());
////////        string reversedN = new string(n.ToString().Reverse().ToArray());
////////        Console.WriteLine($"Число, прочитанное справа налево: {reversedN}");

////////        // 18. Объявить одномерный (5 элементов) массив и двумерный массив (3 строки, 4 столбца)...
////////        int[] A = new int[5];
////////        double[,] B = new double[3, 4];
////////        Random rnd = new Random();

////////        // Заполнение и вывод одномерного массива
////////        Console.WriteLine("Массив A:");
////////        for (int i = 0; i < A.Length; i++)
////////        {
////////            A[i] = rnd.Next(1, 15);
////////            Console.Write(A[i] + " ");
////////        }

////////        Console.WriteLine("\nМассив B:");
////////        for (int i = 0; i < B.GetLength(0); i++)
////////        {
////////            for (int j = 0; j < B.GetLength(1); j++)
////////            {
////////                B[i, j] = Math.Round(rnd.NextDouble() * 100, 2);
////////                Console.Write(B[i, j] + " ");
////////            }
////////            Console.WriteLine();
////////        }

////////        // 19. Удаление из строки знаков / и \
////////        Console.WriteLine("Введите строку для удаления знаков / и \\ :");
////////        string stringWithSymbols = Console.ReadLine();
////////        string stringWithoutSymbols = stringWithSymbols.Replace("/", "").Replace("\\", "");
////////        Console.WriteLine($"Строка без знаков / и \\ : {stringWithoutSymbols}");

////////        // 20. Замена в слове "класс" двух одинаковых букв на "1"
////////        string word = "класс";
////////        int firstOccurrence = word.IndexOf('с');
////////        int lastOccurrence = word.LastIndexOf('с');
////////        if (firstOccurrence != lastOccurrence)
////////        {
////////            word = word.Remove(firstOccurrence, 2).Insert(firstOccurrence, "1");
////////        }
////////        Console.WriteLine($"Модифицированное слово: {word}");

////////        // 21. Подсчет количества цифр в строке
////////        Console.WriteLine("Введите строку для подсчета цифр:");
////////        string strWithDigits = Console.ReadLine();
////////        int digitCount = strWithDigits.Count(char.IsDigit);
////////        Console.WriteLine($"Количество цифр в строке: {digitCount}");

////////        // 22. Проверка наличия слова "one" в тексте
////////        Console.WriteLine("Введите текст для проверки наличия слова 'one':");
////////        string text = Console.ReadLine();
////////        bool containsOne = text.Split(' ').Contains("one", StringComparer.OrdinalIgnoreCase);
////////        Console.WriteLine(containsOne ? "Текст содержит слово 'one'." : "Текст не содержит слово 'one'.");

////////        // 23. Проверка наличия символов, отличных от букв и цифр
////////        Console.WriteLine("Введите текст для проверки наличия символов, отличных от букв и цифр:");
////////        string textForSymbols = Console.ReadLine();
////////        bool hasOtherSymbols = textForSymbols.Any(ch => !char.IsLetterOrDigit(ch));
////////        Console.WriteLine(hasOtherSymbols ? "Текст содержит символы, отличные от букв и цифр." : "Текст состоит только из букв и цифр.");

////////        // 24. Определить, на какую букву начинается больше всего слов в тексте
////////        Console.WriteLine("Введите текст:");
////////        string textForAnalysis = Console.ReadLine();
////////        var words = textForAnalysis.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
////////        var startingLetterCounts = words.GroupBy(w => w[0]).OrderByDescending(g => g.Count());
////////        char mostCommonStartingLetter = startingLetterCounts.First().Key;
////////        Console.WriteLine($"Больше всего слов начинается на букву: {mostCommonStartingLetter}");

////////        // 25. Подсчет количества вхождений буквы P
////////        Console.WriteLine("Введите строку для подсчета вхождений буквы P:");
////////        string stringWithP = Console.ReadLine();
////////        int pCount = stringWithP.Count(c => c == 'P' || c == 'p');
////////        Console.WriteLine($"Количество вхождений буквы P: {pCount}");





//    }
//}
