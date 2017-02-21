using System;

namespace CharityMarathon
{
    public class Marathon
    {
        public static void Main()
        {
            uint days = uint.Parse(Console.ReadLine());
            uint runnersNum = uint.Parse(Console.ReadLine());
            uint avgLaps = uint.Parse(Console.ReadLine());
            uint trackLength = uint.Parse(Console.ReadLine());
            uint trackCapacity = uint.Parse(Console.ReadLine());
            double moneyPK = double.Parse(Console.ReadLine());

            uint runnersMax = days * trackCapacity;
            if (runnersNum > runnersMax)
            {
                runnersNum = runnersMax;
            }
            long totalKM = (long)runnersNum * avgLaps * trackLength / 1000;
            double result = totalKM * moneyPK;

            Console.WriteLine($"Money raised: {result:f2}");
        }
    }
}