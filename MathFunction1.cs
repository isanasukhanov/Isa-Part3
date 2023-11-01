public static class MathFunction1
{
    public static void Start()
    {
        /* Составить программу вычисления
        значения функции y = 7*2+3x+6 при 
        любом значени x; */ 

        int x = Convert.ToInt32(Console.ReadLine());
        int re = 7 * 2 + 3 * x + 6;
        Console.WriteLine(re);
    }        
}
