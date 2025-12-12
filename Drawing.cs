using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

namespace Graphics;

public class Drawing
{
    /// <summary>
    /// Clear the console, calculate the required number of columns (Console.BufferWidth) and rows (Console.BufferHeight - 2),
    /// and fill those cells with the given character c with Console.Write
    /// </summary>
    /// <param name="c"></param>
    public static void DrawRectangle(char c)
    {
        Console.Clear();


        int height = Console.BufferHeight - 2;
        int width = Console.BufferWidth;

        for (int y = 0; y < height; y++)
        {

            for (int x = 0; x < width; x++)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
    public static void DrawRectangleWithSize(char c, int width, int height)
    {


        for (int y = 0; y < height; y++)
        {

            for (int x = 0; x < width; x++)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
    public static void DrawRectangleWithSizeAtOffset(char c, int width, int height, int startX, int startY)
    {
        startX = (Console.BufferWidth - width) / 2;
        startY = (Console.BufferHeight - height) / 2;
        if (startX < Console.BufferWidth && startY < Console.BufferHeight)
        {
            Console.SetCursorPosition(startX, startY);
            for (int y = 0; y < height; y++)
            {
                Console.SetCursorPosition(startX, startY + y);
                for (int x = 0; x < width; x++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }
    public static void AnimateRectangleWithSize(char c, int width, int height, int rounds)
    {

        for (int i = 0; i <= rounds; i++)
        {
            Console.Clear();
            int startX = Random.Shared.Next(0, Console.BufferWidth - width);
            int startY = Random.Shared.Next(0, Console.BufferHeight - height);


            if (startX < Console.BufferWidth && startY < Console.BufferHeight)
            {
                Console.SetCursorPosition(startX, startY);
                for (int y = 0; y < height; y++)
                {
                    Console.SetCursorPosition(startX, startY + y);
                    for (int x = 0; x < width; x++)
                    {
                        Console.Write(c);
                    }
                    Console.WriteLine();
                    
                }
            }
            Thread.Sleep(500);
        }
    }
    public static void BounceRectangleWithSize(int width, int height, int rounds = 200, int random = 0)
    {
        int startX = Random.Shared.Next(0, Console.BufferWidth - width);
        int startY = Random.Shared.Next(0, Console.BufferHeight - height);
        int maxWidth = Console.BufferWidth - width;
        int maxHeight = Console.BufferHeight - height;
        int directionX = 1;
        int directionY = 1;
        
        for (int i = 0; i <= rounds; i++)
        {
            Console.Clear();
            ConsoleColor[] colors = [
 ConsoleColor.Blue,
 ConsoleColor.Cyan,
 ConsoleColor.Red,
 ConsoleColor.Magenta,
 ConsoleColor.Green,
 ConsoleColor.White,
 ConsoleColor.Yellow
];
            


            if (startX < Console.BufferWidth && startY < Console.BufferHeight)
            {
                Console.SetCursorPosition(startX, startY);
                for (int y = 0; y < height; y++)
                {
                    Console.SetCursorPosition(startX, startY + y);
                    for (int x = 0; x < width; x++)
                    {
                        random = Random.Shared.Next(0, 9);
                        int colorIndex = Random.Shared.Next(colors.Length);
                        Console.ForegroundColor = colors[colorIndex];
                        Console.Write(random);
                    }
                    Console.WriteLine();
                }

                if (startX <= 0 || startX >= maxWidth)
                    directionX *= -1;

                if (startY <= 0 || startY >= maxHeight)
                    directionY *= -1;




                startX += directionX;
                    startY += directionY;
            }
            Thread.Sleep(100);
        }
    }
}
  
