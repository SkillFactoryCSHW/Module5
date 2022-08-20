(string Name, string[] Dishes) User;
Console.WriteLine("Please, enter the user name");
User.Name = Console.ReadLine();

User.Dishes = new string[5];
for (int i = 0; i < User.Dishes.Length; i++)
{
    Console.WriteLine("Enter the dish N{0}", i + 1);
    User.Dishes[i] = Console.ReadLine();
}
