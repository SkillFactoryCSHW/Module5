var (name, age) = ("Никита", 28);
Console.Write("Введите имя: ");
name = Console.ReadLine();
Console.Write("Введите возраст с цифрами: ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ваше имя: {0}", name);
Console.WriteLine("Ваш возраст: {0}", age);

string[] favColors = new string[3];

for (int i = 0; i < favColors.Length; i++)
{
    favColors[i] = ShowColor(name, age);
}

static string ShowColor( string name, int age)
{
    string color = "black";
    switch (color)
    {
        case "red":
            color = "red";
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"{name}, {age} лет, your favorite color is {color}");
            break;
        case "yellow":
            color = "yellow";
            Console.WriteLine($"{name}, {age} лет, your favorite color is {color}");
            Console.BackgroundColor = ConsoleColor.Yellow;
            break;
        case "green":
            color = "green";
            Console.WriteLine($"{name}, {age} лет, your favorite color is {color}");
            Console.BackgroundColor = ConsoleColor.Green;
            break;
    }
    return color;
}