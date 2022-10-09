using ConsoleApp14;
using System.ComponentModel;
using System.Xml.Linq;


void GetMenu()
{
    Console.WriteLine($"1) Взять книги");
    Console.WriteLine($"2) Вернуть книги");
    Console.WriteLine($"3) Информация о взявших книги");
}
void Menu()
{  
    Reader reader = new Reader();
    while (true)
    {
        GetMenu();
        
        string a = Console.ReadLine();
        int menu = int.Parse(a);
        if (menu == 1)
        {
            Console.Write($"Имя: ");
            string name = Console.ReadLine();
            Console.Write($"фамилия: ");
            string surname = Console.ReadLine();
            Console.Write($"Отчество: ");
            string patronymic = Console.ReadLine();
            Console.Write($"количество взятых книг: ");
            string book = Console.ReadLine();
            int nbook = int.Parse(book);
            Console.Write($"Номер телефона: ");
            string number = Console.ReadLine();
            Reader reader2 = new Reader(name, surname, patronymic, nbook, number);
            Console.WriteLine();
            reader2.Get(reader2);
            reader.TakeBook(name, surname, patronymic, nbook, number);
        }
        else if (menu == 2)
        {
            Console.WriteLine();
            Console.WriteLine($"Введите фамилию");
            string surname= Console.ReadLine();
            reader.ReturnBook(surname);
        }
        else if (menu == 3)
        {
            
            reader.GetInfo();
        }
    }
}
Menu();