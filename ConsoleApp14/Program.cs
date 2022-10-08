using ConsoleApp14;

Reader reader=new Reader();
void GetMenu()
{
    Console.WriteLine($"1) Взять книги");
}
void Menu()
{
    GetMenu();
    string a= Console.ReadLine();
    int menu= int.Parse(a);
    if (menu == 1)
    {
        Console.Write($"Имя:");
        string name= Console.ReadLine();
        Console.Write($"фамилия :");
        string surname = Console.ReadLine();
        Console.Write($"Отчество:");
        string patronymic = Console.ReadLine();
        Console.Write($"количество взятых книг:");
        string book = Console.ReadLine();
        int nbook= int.Parse(a);
        Console.Write($"Номер телефона: ");
        string number= Console.ReadLine();
        reader.TakeBook(name,surname,patronymic,nbook,number);
        Reader reader2= new Reader(name, surname, patronymic, nbook, number);
    }
}
Menu();