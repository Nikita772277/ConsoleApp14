using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Reader
    {
        private string _name;//имя
        private string _surname;//фамилия
        private string _patronymic;//отчество
        private string _faculty;//факультет
        private string _dateofbirth;//дата рождения
        private string _number;//телефон
        private List<Reader> _info= new List<Reader>();
        private int _book;
        public Reader(string name, string surname, string patronymic, int book, string number)
        {
            _name = name;
            _surname = surname;
            _patronymic = patronymic;
            _book = book;
            _number = number;
        }
        public Reader()
        {

        }
        public void TakeBook()//взять книгу
        {
           if (_book == )
           {
                Console.WriteLine($"можете идти");
           }
           else if (_book == 0)
            Console.WriteLine($"");
            
        }
        public void TakeBook( string name, string surname,string patronymic,int book, string number)
        {
            Console.WriteLine($"{name}.{surname}.{patronymic}. взял: {book} книг");
            _book=book;
        }
        public void Get(Reader reader1)
        {
            _info.Add(reader1);
        }
        
        public void ReturnBook()//вернуть книгу
        {

        }


    }
}
