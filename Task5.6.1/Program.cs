var user = UserEnter();

Console.WriteLine("Information about user:");
Console.WriteLine($"First name: {user.firstName}");
Console.WriteLine($"Last name: {user.lastName}");
Console.WriteLine($"Age: {user.age}");

if(user.pet == true)
{
    Console.WriteLine($"There is a pet in quantity: {user.petNum}");
    Console.WriteLine($"Their names:");
    ShowArrayPet(user.pets);
}

Console.WriteLine("User favorite colors:");
ShowArrayColors(user.colors);

//Check numeric value
static bool CheckNum(string number, out byte corrNumber)
{
    if (byte.TryParse(number, out byte byteNum))
    {
        if (byteNum > 0)
        {
            corrNumber = byteNum;
            return false;
        }
    }
    {
        corrNumber = 0;
        return true;
    }

}

//Enter pets
static string[] PetNamesList(byte PetNum)
{
    Console.WriteLine("List theit names");
    string[] arrayPetNames = new string[PetNum];
    for (int i = 0; i < arrayPetNames.Length; i++)
    {
        Console.WriteLine($"Name N{i + 1}: ");
        arrayPetNames[i] = Console.ReadLine();
    }
    return arrayPetNames;
}
//Show pets names
static void ShowArrayPet(string[] arrayPetNames)
{
    for (int i = 0; i < arrayPetNames.Length; i++)
    {
        Console.Write(arrayPetNames[i] + ", ");
    }
    Console.WriteLine();
}

//Enter favorite colors
static string[] ColorsList(byte colorNum)
{
    Console.WriteLine("Enter your favorite colors");
    string[] arrayColors = new string[colorNum];
    for (int i = 0; i < arrayColors.Length; i++)
    {
        Console.WriteLine($"Name N{i + 1}: ");
        arrayColors[i] = Console.ReadLine();
    }
    return arrayColors;
}
//Show favotite colors
static void ShowArrayColors(string[] arrayColors)
{
    for (int i = 0; i < arrayColors.Length; i++)
    {
        Console.Write(arrayColors[i] + ", ");
    }
    Console.WriteLine();
}

static (string firstName, string lastName, byte age, bool pet, byte petNum, string[] pets, byte colorNum, string[] colors) UserEnter()
{
    (string firstName, string lastName, byte age, bool pet, byte petNum, string[] pets, byte colorNum, string[] colors) UserInfo;
   //Enter user name
    Console.WriteLine("Enter your name");
    UserInfo.firstName = Console.ReadLine();
    //Enter last name
    Console.WriteLine("Enter your last name");
    UserInfo.lastName = Console.ReadLine();

    //Enter age
    byte byteAge;
    string age;
    Console.WriteLine("How old are you?");
    do
    {
        Console.WriteLine("Enter a numeric value");
        age = Console.ReadLine();
    } while (CheckNum(age, out byteAge));
    UserInfo.age = byteAge;

    //Info about pets
    string petYN;
    Console.WriteLine("Do you have a pet?");
    do
    {
        Console.WriteLine("Please, enter Y or N");
        petYN = Console.ReadLine();
    } while (petYN != "Y" & petYN != "N");

    if (petYN == "Y")
    {
        UserInfo.pet = true;
        byte bytePet;
        string petStr;
        Console.WriteLine("How many pets do you have?");
        do
        {
            Console.WriteLine("Enter a numeric value");
            petStr = Console.ReadLine();
        } while (CheckNum(petStr, out bytePet));
        UserInfo.petNum = bytePet;

        //Enter pets names
        UserInfo.pets = PetNamesList(UserInfo.petNum);
    }
    else
    {
        UserInfo.pet = false;
        UserInfo.petNum = 0;
        UserInfo.pets = new string[0];
    }

    //Favorite colors
    byte byteColor;
    string colorStr;
    Console.WriteLine("How many favotite colors do you have?");
    do
    {
        Console.WriteLine("Enter a numeric value");
        colorStr = Console.ReadLine();
    } while (CheckNum(colorStr, out byteColor));
    UserInfo.colorNum = byteColor;

    UserInfo.colors = ColorsList(UserInfo.colorNum);

    return UserInfo;
}