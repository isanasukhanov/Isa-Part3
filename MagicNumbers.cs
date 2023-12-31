public static class MagicNumbers
{
    public static void Start()
    {
        /* Задача "Магические числа"

        Описание:
        Нужно создать программу для нахождения магических чисел в массиве.
        Магическим числом называется число, которое: Чётное.
        Если его умножить на 2, результат также есть в массиве.
        Задание:
        Создайте одномерный массив из 20 элементов, заполненный случайными числами в диапазоне от 1 до 100.
        Найдите и выведите все магические числа из этого массива. Если магическое число найдено,
        не проверяйте следующие условия для текущего числа (используйте continue).
        Если магическое число не найдено во всем массиве, выведите сообщение об этом. */


        // Создаем массив из случайных чисел на 20 ячеек. 
        int[] randomNumbers = new int[20];
        // Создаем генератор случайных чисел.
        Random rand = new Random();
        // Находим 20 чисел с генератором случайных чисел.
        for (int i = 0; i < 20; i++)
        {
            // Находим числа от 1 до 100.
            randomNumbers[i] = rand.Next(1, 100);
        }
 
        // Находим 20 чисел с генератором случайных чисел.
        bool proverkaMagicChislo = false;
        for (int i = 0; i < 20; i++)
        {
            // Находим четные числа деляшиеся на 2.
            int razdelenie = randomNumbers[i] % 2;
            // Условия не равно 0.

            if (razdelenie != 0)
            {
                continue;
            }
          
            // Нечетные числа умножаем на 2.
            int umnojenie = randomNumbers[i] * 2;
           
            // Контейнируем нечетные числа и умноженные 2 числа
            if (randomNumbers.Contains(umnojenie))
            {
                proverkaMagicChislo = true;
                // Выводим найденые четные числа.
                Console.WriteLine($"Магическое число: {randomNumbers[i]}");
            }
        } 
        if (proverkaMagicChislo == false)
        {
            Console.WriteLine("Магическое число не найдено во всем массиве. ");
        }

    }
}  