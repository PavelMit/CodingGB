

// создание кубика
void EmptyDice(int x, int y)
{
    for (int yCurrent = 0; yCurrent <= 10; yCurrent += 2)
    {
        if (yCurrent == 0 || yCurrent == 10)
        {
            for (int xCurrent = 0; xCurrent <= 20; xCurrent += 4)
            {
                Console.SetCursorPosition(x + xCurrent, y + yCurrent);
                Console.Write("*");
            }
        }
        else
        {
            Console.SetCursorPosition(x, y + yCurrent);
            Console.Write("*");
            Console.SetCursorPosition(x + 20, y + yCurrent);
            Console.Write("*");
        }
    }
}
void Dice(int number, int x, int y)
{
    EmptyDice(x, y);
    if (number == 1)
    {
        Console.SetCursorPosition(x + 10, y + 5);
        Console.Write("X");
    }
}


Dice(1, 1, 1);


// создание кубика c определенным количество точек
