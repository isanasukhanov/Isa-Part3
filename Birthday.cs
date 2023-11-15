public static class Birthday
{
    public static void Start()
    {
        /* На основе года, месяца и дня рождения пользователя,
        а также текущей даты, узнать сколько ему полных лет.
        Пример ввода:
        - Год вашего рождения? 1989
        - Месяц? 2
        - День? 9

        Пример вывода:
        - Поздравляем! Вам 34 года!  */

        Console.Write($" - Год вашего рождения? ");
        int godRojdenie = Convert.ToInt32(Console.ReadLine());

        Console.Write($" - Месяц? ");
        int mesyac =  Convert.ToInt32(Console.ReadLine());

        Console.Write($" - День? "); 
        int den = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($" - Поздравляем вам {DateTime.Now.Year - godRojdenie} лет!");
        Console.WriteLine($" - Месяц {DateTime.Now.Month - mesyac}");
        Console.WriteLine($" - День {DateTime.Now.Day - den}");
    }
}
