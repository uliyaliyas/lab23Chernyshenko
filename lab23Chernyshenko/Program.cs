class Polusharie
{
    static void Main()
    {
        CheckHemisphere(30, 121);
        CheckHemisphere(-15, 50);
        CheckHemisphere(87, 223);
    }
    static void CheckHemisphere(int F, int D)
    {
        if (F >= 0)
        {
            Console.Write("Северo - ");
        }
        else
        {
            Console.Write("Южно - ");
        }

        if (D >= 0)
        {
            Console.WriteLine("восточное полушарие.");
        }
        else
        {
            Console.WriteLine("западное полушарие.");
        }
    }
}