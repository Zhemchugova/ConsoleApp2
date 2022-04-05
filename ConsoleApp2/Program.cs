// See https://aka.ms/new-console-template for more information
Console.Write("**\n" +
              "*              \n" +
              "              \n" +
              "              \n" +
              "              \n" +
              "              \n" +
              "              \n" +
              "              \n" +
              "              *\n" +
              "**");

int x = 0, y = 0;
int shiftX = 8, shiftY = 4;
Console.SetCursorPosition(x + shiftX, y + shiftY);
Console.Write("@");

ConsoleKeyInfo move = Console.ReadKey(true);

Console.SetCursorPosition(x + shiftX, y + shiftY);
Console.Write(" ");
switch (move.Key)
{
    case ConsoleKey.W:
        y--;

        break;
    case ConsoleKey.A:
        x--;
        break;
    case ConsoleKey.S:
        y++;
        break;
    case ConsoleKey.D:
        x++;
        break;
}
Console.SetCursorPosition(x + shiftX, y + shiftY);
Console.Write("@");
Console.SetCursorPosition(15, 15);
