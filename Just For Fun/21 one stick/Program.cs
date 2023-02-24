Console.Clear();
Console.Write("Привет, мой друг. Сегодня мы сыграем в игру, которая называется 21 палочка. Введи да, если готов: ");
string answer = Console.ReadLine();
while (answer != "да")
{
    Console.WriteLine("Я не получил корректный ответ. Если будешь готов, напиши да");
    answer = Console.ReadLine();
}
int sticks = 21;
Console.WriteLine("Отлично, тогда приступим. Представь, что перед тобой 21 палочка. Мы будем с ними играть. Ты видишь их ниже.");
Console.WriteLine();
tring ShowSticksLeft(sticks);
Console.WriteLine();
Console.WriteLine("ПРАВИЛА: Мы будем брать палочки поочереди: ты, я, ты, я и т.д. Можнно брать 1, 2 или 3 палочки за раз. Кто заберет последнюю - програл.");
Console.WriteLine("Для начала давай решим, кто будет брать первым: ты или я. Если, хочешь начать, введи /я/, если хочешь быть вторым - введи /ты/");

string ShowSticksLeft(int sticks)
{
    string lineOfSticks = "";
    int counter = 1;
    while (counter <= sticks)
    {
        lineOfSticks = lineOfSticks + " |";
        counter++;
    }
    return lineOfSticks;
}


string answer2 = Console.ReadLine();
int turn = 1;
int hand = 0;
int counter = 1;

while (answer2 != "я" && answer2 != "ты")
{
    Console.WriteLine("Пожалуйста, напишите первый, если хотите брать палочки первыми или второй, если хотите, чтобы я начал");
    answer2 = Console.ReadLine();
}

if (answer2 == "ты") turn = 2;

while (sticks != 1)
{
    if (turn == 2)
    {
        if (sticks < 5) hand = sticks - 1;
        else 
        {
            if(sticks == 21) hand = new Random().Next(1, 4);
            else hand = (sticks-1) % 4;
                if (hand == 0) hand = new Random().Next(1, 4);
        }
        Console.WriteLine($"Я беру {hand}");
        Console.WriteLine($"Осталось {sticks-hand}");
        turn = 1;
    }
    else
    {
        if (sticks < 5)
        {
            while (hand > sticks - 1)
            {
                Console.WriteLine($"Напомню еще раз: задача, чтобы последняя палочка досталась сопернику. Подумай еще раз: сколько ты возьмешь?");
                hand = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Я беру {hand}");
            Console.WriteLine($"Осталось {sticks-hand}");
        }
        else 
        {
            Console.WriteLine("Сколько ты возьмешь от 1 до 3?");
            Console.WriteLine(ShowSticksLeft(sticks));
            hand = Convert.ToInt32(Console.ReadLine());
            while (hand > 3 || hand < 0)
            {
                Console.WriteLine($"{hand} - это не доступное количество палочек. Возьмите от 1 до 3. Сколько выберете?");
                hand = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Осталось {sticks-hand} ");
            Console.WriteLine(ShowSticksLeft(sticks-hand));
        }
        turn = 2;
    }
    sticks -= hand;
}

if (turn == 1) Console.WriteLine("Ты проиграл, ха-ха-ха!");
else Console.WriteLine("Поздравляю с победой");
