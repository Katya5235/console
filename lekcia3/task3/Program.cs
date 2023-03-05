

int[] arr = { 5, 2, 6, 8, 9, 4, 8 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");

    }
    Console.WriteLine();
}


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = i;

        for (int k = i + 1; k < array.Length; k++)
        {
            if (array[k] < array [min]) min = k;
        }


        int temp = array[i];
        array[i] = array[min];
        array[min] = temp;

    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);