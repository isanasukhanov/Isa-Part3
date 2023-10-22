
// Упражнение Торты.
//0) Создать цены и название всех тортов.
//1) Вывести текст (Муьлха торт еза хьуна?:)
//2) Палучить название торта 
//3) сохранить название торта
//4) Сравнить название торта с имеюшимися тортами


using System;

public static class Cake
{
    public static void Start()
    {
        string tort1 = "Тортик";
        string tort2 = "Тортище";
        string tort3 = "Торт95";
        string tortino = "Тортиньо йац нету давай досвидание";

        int tort1cena = 1507;
        int tort2cena = 3600;
        int tort3cena = 200;

        Console.Write("Муьлха торт еза хьуна?: ");

        string otvetpolzovatelya = Console.ReadLine();

        if (otvetpolzovatelya == tort1)
        {
            Console.WriteLine($"{tort1} ах {tort1cena} сом доьху");
        }
        else if (otvetpolzovatelya == tort2)
        {

            Console.WriteLine($"{tort2} {tort2cena} сом доьху");
        }
        else if (otvetpolzovatelya == tort3)
        {
            Console.WriteLine($"{tort3} {tort3cena} сом доьху");
        }
        else if (otvetpolzovatelya == tortino) ;
        {
            Console.WriteLine($"{tortino}");
        }
    }
}

