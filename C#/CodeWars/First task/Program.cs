
string HighAndLow(string numbers)
{
    int high = Convert.ToInt32(numbers[0] - 48);
    int low = Convert.ToInt32(numbers[0] - 48);
    for (int i = 0; i < numbers.Length - 1; i =+ 2)
    {
        if (Convert.ToInt32(numbers[i + 1]) - 48 > high)
            high = Convert.ToInt32(numbers[i + 1] - 48);
        if (Convert.ToInt32(numbers[i + 1]) - 48 < low)
            low = Convert.ToInt32(numbers[i + 1]) - 48; 
    }
    return Convert.ToString(high) + " " + Convert.ToString(low);
}

Console.Write("Please input a string: ");
string newStr = Console.ReadLine();
Console.WriteLine(HighAndLow(newStr));
