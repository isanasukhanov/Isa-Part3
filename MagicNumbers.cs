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



        int[] magicNumbers = new int[20];
        Random rand = new Random();

        for (int i = 0; i < 20; i++)
        {
            magicNumbers[i] = rand.Next(1, 100);
        }

        for (int i = 0; i < 20; i++)
        {
            int razdelenie = magicNumbers[i] % 2;
            if (razdelenie != 0)
            {
                continue;
            }
            int umnojenie = magicNumbers[i] * 2;
            if (magicNumbers.Contains(umnojenie))
            {
                Console.WriteLine($"Магическое число: {magicNumbers[i]}");
            }
        } 

         /*   
        for (int i = 0; i < 1; i++) 
        {   
            
            {
                Console.WriteLine($"Магическое число не найдено во всем массиве. {i}");
            }
        }
         */
    }
}  