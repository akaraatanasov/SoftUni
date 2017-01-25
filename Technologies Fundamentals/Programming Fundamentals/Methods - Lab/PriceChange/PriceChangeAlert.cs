using System;

class PriceChangeAlert
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double granica = double.Parse(Console.ReadLine());
        double last = double.Parse(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            double numberOfPrices = double.Parse(Console.ReadLine());
            double div = Proc(last, numberOfPrices);
            bool isSignificantDifference = Difference(div, granica);
            string message = Get(numberOfPrices, last, div, isSignificantDifference);
            Console.WriteLine(message);
            last = numberOfPrices;
        }
    }

    public static string Get(double numberOfPrices, double last, double razlika, bool etherTrueOrFalse)
    {
        string to = "";
        if (razlika == 0)
        {
            to = string.Format("NO CHANGE: {0}", numberOfPrices);
        }
        else if (!etherTrueOrFalse)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:f2}%)", last, numberOfPrices, razlika*100);
        }
        else if (etherTrueOrFalse && (razlika > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, numberOfPrices, razlika*100);
        }
        else if (etherTrueOrFalse && (razlika < 0))
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, numberOfPrices, razlika*100);
        return to;
    }

    private static bool Difference(double granica, double isDiff)
    {
        if (Math.Abs(granica) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double Proc(double l, double c)
    {
        double r = (c - l) / l;
        return r;
    }
}