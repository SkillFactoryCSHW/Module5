int[] array = GetArrayFromConsole();
SortArray(array);
ShowArray(array);

static int[] GetArrayFromConsole()
{
    int[] array = new int[5];

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите элемент массива номер {0}", i + 1);
        array[i] = int.Parse(Console.ReadLine());
    }

    return array;
}

static int[] SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j + 1] < array[j])
            {
                int temp = array[j + 1];
                array[j + 1] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}

static void ShowArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write(i + " ");
    }
}