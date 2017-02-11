using System.IO;

namespace FolderSize
{
    public class Size
    {
        public static void Main()
        {
            var currentDirectory = Directory.GetFiles("TestFolder");
            double sum = 0;

            foreach (var file in currentDirectory)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            sum = sum / 1024 / 1024;

            File.WriteAllText("Output.txt", sum.ToString());
        }
    }
}