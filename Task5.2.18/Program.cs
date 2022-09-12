int[] array = new int[10];
array = Array(array);
ShowSortArray(array);

static int[] Array(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Enter the value {i}");
        array[i] = Int32.Parse(Console.ReadLine());
    }
    return array;
}

static void ShowSortArray(int[] array)
{
    int temp;
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j + 1] < array[j])
            {
            temp = array[j + 1];
            array[j + 1] = array[j];
            array[j] = temp;
            }
        }

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Element N{i + 1}: {array[i]}");
    }
}
