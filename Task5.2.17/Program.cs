int[] array = { 3, 1, 4, 2, 5 };
bool sortarray = true;
ShowArray(array, sortarray);

static void ShowArray(int[] array, bool sortarray = false)
{
    if(sortarray)
    {
        int temp;
        for (int j = 0; j < array.Length; j++)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i + 1] < array[i])
                {
                    temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
                }
            }
        }
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}