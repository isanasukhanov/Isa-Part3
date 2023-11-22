/* Задача: Анализ данных о погоде

Напишите программу на C#, которая анализирует ежедневные данные о погоде за месяц. Данные о погоде представлены в виде массива,
где каждый элемент содержит информацию о температуре (в градусах Цельсия) и количестве осадков (в миллиметрах) за день.

Входные данные:

Массив int[] temperatures с температурами за каждый день месяца.
Массив int[] precipitation с количеством осадков за каждый день месяца.

Требования к программе:

Рассчитать среднюю месячную температуру.
Определить самый холодный и самый теплый дни в месяце.
Посчитать общее количество осадков за месяц.
Найти количество дней с осадками выше среднего.
Вывести индексы дней, когда была заморозка (температура ниже 0 градусов Цельсия) и осадки были выше, чем в предыдущий день.

Выходные данные:

Вывести на экран среднюю месячную температуру.
Вывести индексы самого холодного и самого теплого дня.
Вывести общее количество осадков за месяц.
Вывести количество дней с осадками выше среднего.
Вывести индексы дней с заморозками и увеличением осадков по сравнению с предыдущим днем. */

public static class WeatherInformation
{
    public static void Start()
    {
        //температуры от -40 до 50, осадки от 0 до 100
        //тебе надо узнать сумму всех значений температур в месяце 
        
        int [] temperatures = new int[30];
        int [] precipitation = new int[30];
        Random rand = new Random();

         for (int i = 0; i < temperatures.Length; i++)
        {
            temperatures[i] = rand.Next(-40, 50);
            precipitation[i] = rand.Next(0, 100);
            Console.WriteLine($"Количество осадков за каждый день месяца: {precipitation[i]}");
            Console.WriteLine($"Температура за каждый день месяца: {temperatures[i]}");
        }
        Console.WriteLine();
        int temperatures1 = 0;
        for (int i = 0; i < temperatures.Length; i++)
        {
            temperatures1 += temperatures[i];
        }
        int averageTemperature = temperatures1 / temperatures.Length;
        Console.WriteLine($"Средняя месечная температура:  {averageTemperature}");

        int minTemp = temperatures[0];
        int maxTemp = temperatures[0];

        for (int i = 0; i < temperatures.Length; i++)
        {
            if (temperatures[i] < minTemp)
            {
                minTemp = temperatures[i];
            }
            if (temperatures[i]>maxTemp)
            {
                maxTemp = temperatures[i];
            }
        }
        Console.WriteLine($"Температура самого холодного дня:  {minTemp}");
        Console.WriteLine($"Температура самого теплого дня:  {maxTemp}"); 

        Console.Write("Общее количество осадков за месяц: ");
        int allPrecipitation = 0;
        for (int i = 0; i < precipitation.Length; i++)
        {
            allPrecipitation += precipitation[i];
        }
        Console.WriteLine(allPrecipitation);

        /* Console.WriteLine("Количество дней с осадками выше среднего");
            int[] daysWithUpAveragePrecipitation = { };

            int x = 0;
            foreach (int precipitation in precipitationS)
            {
                if (precipitation > averagePrecipitation)
                {
                    x++;
                    Array.Resize(ref daysWithUpAveragePrecipitation, x);
                    daysWithUpAveragePrecipitation[x - 1] = precipitation;
                }
            }
            Console.WriteLine(daysWithUpAveragePrecipitation.Length); */

        Console.WriteLine("Количество дней с осадками выше среднего");

    }

}