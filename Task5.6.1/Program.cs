static bool CheckNum(string number, out int corrnumber)
{
    if (int.TryParse(number, out int intnum))
    {
        if (intnum > 0)
        {
            corrnumber = intnum;
            return false;
        }
    }
    {
        corrnumber = 0;
        return true;
    }
}

static (string name, string lastName, int age) EnterUser()
{
    (string name, string lastname, int age) User;

    Console.WriteLine("Введите имя");
    User.name = Console.ReadLine();

    Console.WriteLine("Введите фамилию");
    User.lastname = Console.ReadLine();

    string age;
    int intage;
    do
    {
        Console.WriteLine("Введите возраст цифрами");
        age = Console.ReadLine();
    } while (CheckNum(age, out intage));

    User.age = intage;

    return User;
}