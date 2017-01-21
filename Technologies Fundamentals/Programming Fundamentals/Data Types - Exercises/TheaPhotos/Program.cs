using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaPhotos
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int usefulPrecentage = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());
            int totalFilter = filterTime * totalPictures;
            double filteredPictures = Math.Ceiling(usefulPrecentage * 0.01 * totalPictures);
            int totalUpload = uploadTime * (int)filteredPictures;
            int totalTime = totalFilter + totalUpload;
            int days = totalTime / 86400;
            totalTime -= days * 86400;
            int hours = totalTime / 3600;
            totalTime -= hours * 3600;
            int minutes = totalTime / 60;
            totalTime -= minutes * 60;
            int seconds = totalTime;
            Console.WriteLine($"{days}:{hours:00}:{minutes:00}:{seconds:00}");
        }
    }
}