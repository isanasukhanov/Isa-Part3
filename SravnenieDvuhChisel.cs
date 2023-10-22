public static class SravnenieDvuhChisel
{
    public static void Start()
    {

        int chisloA = Convert.ToInt32(Console.ReadLine());
        int chisloB = Convert.ToInt32(Console.ReadLine());

        if (chisloA > chisloB)
        {
            Console.WriteLine($"Число А {chisloA} больше, чем Число Б {chisloB}");
        }
        if (chisloA == chisloB)
        {
            Console.WriteLine($"Число А {chisloA} равно, Число Б {chisloB}");
        }
        if (chisloA != chisloB)
        {
            Console.WriteLine($"Число А {chisloA} не равно, Число Б {chisloB}");
        }
        if (chisloA < chisloB)
        {
            Console.WriteLine($"Число А {chisloA} меньше, чем Число Б {chisloB}");
        }
    }
}









