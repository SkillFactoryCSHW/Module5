int[] array = { 3, 1, 2, 5, 4 };
int[] sortAsc, sortDesc;

Sortarray(array, out sortAsc, out sortDesc);
ShowArray(sortAsc, sortDesc);

static void Sortarray(int[] array, out int[] sortAsc, out int[] sortDesc)
{
    sortAsc = SortedAsc(array);
    sortDesc = SortedDesc(array);
}

static int[] SortedAsc(int[] array)
{
    int[] sortAsc = new int[array.Length];
    for (int i = 0; i < sortAsc.Length; i++)
    {
        sortAsc[i] = array[i];
    }
    int temp;
    for (int i = 0; i < sortAsc.Length; i++)
    {
        for (int j = 0; j < sortAsc.Length - 1; j++)
        {
            if (sortAsc[j + 1] < sortAsc[j])
            {
                temp = sortAsc[j + 1];
                sortAsc[j + 1] = sortAsc[j];
                sortAsc[j] = temp;
            }
        }
    }
    return sortAsc;
}

static int[] SortedDesc(int[] array)
{
    int[] sortDesc = new int[array.Length];
    for (int i = 0; i < sortDesc.Length; i++)
    {
        sortDesc[i] = array[i];
    }
    int temp;
    for (int i = 0; i < sortDesc.Length; i++)
    {
        for (int j = 0; j < sortDesc.Length - 1; j++)
        {
            if (sortDesc[j + 1] > sortDesc[j])
            {
                temp = sortDesc[j + 1];
                sortDesc[j + 1] = sortDesc[j];
                sortDesc[j] = temp;
            }
        }
    }
    return sortDesc;
}

static void ShowArray(int[] sortAsc, int[] sortDesc)
{
    for (int i = 0; i < sortAsc.Length; i++)
    {
        Console.Write(sortAsc[i] + " ");
    }
    Console.WriteLine();

    for (int j = 0; j < sortDesc.Length; j++)
    {
        Console.Write(sortDesc[j] + " ");
    }
    Console.WriteLine();
}