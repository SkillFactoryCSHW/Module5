string[] colorArray = new string[3];
for (int i = 0; i < colorArray.Length; i++)
{
    colorArray[i] = ShowColor(i);
}
ShowArray(colorArray);

static void ShowArray(string[] colorArray)
{
    for (int i = 0; i < colorArray.Length; i++)
    {
        Console.WriteLine($"Your favorite color N{i + 1} is {colorArray[i]}");
    }
}

static string ShowColor(int i)
{
    Console.WriteLine("Enter your favorite color N{0}", i + 1);
    string favColor = Console.ReadLine();
    return favColor;
}