// int[] scores = { 60, 80, 40, 80, 90 };

// Console.WriteLine($"Сумма: {GetSum(scores)}");
// Console.WriteLine($"Минимум: {GetMin(scores)}");
// Console.WriteLine($"Максимум: {GetMax(scores)}");
// Console.WriteLine($"Количество 50+: {GetCount(scores, 50)}");
// Console.WriteLine($"Первый индекс 80: {GetIndex(scores, 80)}");

// int GetSum(int[] arr) => arr.Sum();
// int GetMin(int[] arr) => arr.Min();
// int GetMax(int[] arr) => arr.Max();
// int GetCount(int[] arr, int limit) => arr.Count(x => x >= limit);
// int GetIndex(int[] arr, int val) => Array.IndexOf(arr, val);


// int[] scores = { 60, 80, 40, 80, 90 };
// int sum = 0;
// foreach (int score in scores)
// {
//     sum += score;
// }
// int SumArray(int[] numbers)
// {
//     int sum = 0;

//     foreach (int number in numbers)
//     {
//         sum += number;
//     }

//     return sum;
// }
// Console.WriteLine(SumArray(scores));



// int SumArray(int[] numbers) 
// {
//     int sum = 0; // Начинаем с нуля
//     foreach (int number in numbers) 
//     {
//         sum += number;
//     }
//     return sum;
// }
// Console.WriteLine(SumArray(new int[] { 5, -2, 7 }));



// int CountAtLeast(int[] numbers, int limit)
// {
//     int count = 0;
//     foreach (int number in numbers)
//     {
//         if (number >= limit)
//         {
//             count++;
//         }
//     }
//     return count;
// }
// Console.WriteLine(CountAtLeast(new int[] { 40, 50, 80 }, 50));


int FindMin(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
    {
        throw new ArgumentException("Массив не должен быть пустым");
    }

    int min = numbers[0]; 

    foreach (int number in numbers)
    {
        if (number < min)
        {
            min = number;
        }
    }

    return min;
}
Console.WriteLine(FindMin(new int[] { 12, 4, 9 }));