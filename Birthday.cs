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

        Console.Write(" -Год вашего рождения? ");
        int godRojdenie = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($" Поздравляем вам {DateTime.Now.Year - godRojdenie} года!!!");
        Console.WriteLine($"- Месяц? 2");
        Console.WriteLine($"- День? 5");
    }
}