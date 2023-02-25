// Поиск элемента в массиве

int[] array = { 1, 25, 3, 4, 25, 67, 7, 84, };
int n = array.Length;
int find = 25;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}


