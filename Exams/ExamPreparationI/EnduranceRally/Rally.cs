using System;
using System.Collections.Generic;
using System.Linq;

namespace EnduranceRally
{
    public class Rally
    {
        public static void Main()
        {
            try
            {
                var driverNames = Console.ReadLine().Split(' ').ToArray();
                var zones = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
                var checkpointIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                foreach (var driver in driverNames)
	            {
                    double startFuel = driver[0];
                    int checkpointCount = 0;

                    for (int i = 0; i < zones.Count(); i++)
                    {
                        bool flag = false;

                        for (int index = 0; index < checkpointIndexes.Count(); index++)
                        {
                            if (i == checkpointIndexes[index])
                            {
                                flag = true;
                                break;
                            }
                        }

                        if (flag)
                        {
                            startFuel += zones[i];
                        }
                        else
                        {
                            startFuel -= zones[i];
                        }

                        if (startFuel <= 0)
                        {
                            Console.WriteLine("{0} - reached {1}", driver, checkpointCount);
                            break;
                        }
                        else
                        {
                            checkpointCount++;
                        }
                    }

                    if (startFuel > 0)
                    {
                        Console.WriteLine("{0} - fuel left {1:f2}", driver, startFuel);
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorect input!");
            }
            
        }
    }
}