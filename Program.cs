using Graphics;
Console.WriteLine("Drawing Rectangles");

//Drawing.DrawRectangle('#');
//Drawing.DrawRectangleWithSize('#', 5, 5);
//Drawing.DrawRectangleWithSizeAtOffset('#', 5, 5, 0, 0);// geht fur ganze lvl2
//Drawing.AnimateRectangleWithSize('#', 5, 5, 20);
Drawing.BounceRectangleWithSize(6, 7, 10000);// habe hier mit random numbers gemacht, weil schaut cooler aus, 
/*
 *  public static void BounceRectangleWithSize(int random, int width, int height, int rounds = 200)// Moglichkeit mit random number
 *   public static void BounceRectangleWithSize(char c, int width, int height, int rounds = 200)Moglichkeit mit random char !, @, #, $ ... 
 */

Console.ReadKey();

