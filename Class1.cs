int Sum(int[] numbers)
{
    int limit = 0;
    int result = 0;
    foreach (int number in numbers)
    {
        if (IsPassed(number)) result += number;
    }
    return result;

    bool IsPassed(int number)
    {
        return number > limit;
    }
}

int[] numbers1 = { -3, -2, -1, 0, 1, 2, 3 };
int[] numbers2 = { 3, -4, 5, -6, 7 };

Console.WriteLine(Sum(numbers1));
Console.WriteLine(Sum(numbers2));