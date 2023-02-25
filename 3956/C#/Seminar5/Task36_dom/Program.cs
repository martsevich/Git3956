// Задача 36:
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int length, int leftnum = int.MinValue, int rightnum = int.MaxValue)
{
    int[] rand_arr = new int[length];
    for (int i = 0; i < rand_arr.Length; i++)
    {
        rand_arr[i] = Random.Shared.Next(leftnum, rightnum);
    }
    return rand_arr;
}

int[] LengthArray(int[] array)
{
    if(array.Length % 2 == 0) 
    {
        return new int[array.Length / 2];
    }
    else
    {
        return new int[array.Length / 2 + 1];
    }
}

int[] filled_array = FillArray(5, -10, 10);

Console.WriteLine(FillArray);
//Console.WriteLine($"{string.Join(", ", filled_array)} -> {string.Join(", ", MultiplyArray(filled_array))}");