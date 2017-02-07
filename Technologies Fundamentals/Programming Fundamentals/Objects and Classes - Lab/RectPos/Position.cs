using System;
using System.Linq;

namespace RectPos
{
    public class Position
    {
        public static void Main()
        {
            var firstInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var firstRectangle = new Rectangle
            {
                Left = firstInput[0],
                Top = firstInput[1],
                Width = firstInput[2],
                Height = firstInput[3]
            };

            var secondRectangle = new Rectangle
            {
                Left = secondInput[0],
                Top = secondInput[1],
                Width = secondInput[2],
                Height = secondInput[3]
            };

            Console.WriteLine((IsInside(firstRectangle, secondRectangle)?"Inside":"Not inside"));
        }

        public static bool IsInside(Rectangle first, Rectangle second)
        {
            var leftIsCorrect = first.Left >= second.Left;
            var rightIsCorrect = first.Right <= second.Right;
            var bottomIsCorrect = first.Bottom >= second.Bottom;
            var topIsCorrect = first.Top <= second.Top;

            return leftIsCorrect && rightIsCorrect && bottomIsCorrect && topIsCorrect;
        }
    }
}