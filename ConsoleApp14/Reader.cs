using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        List<Reader> info= new List<Reader>();
        private int _book;
        public Reader()
        {

        }
        public Reader(string name, string surname, string patronymic, int book, string number)
        {
            _name = name;
            _surname = surname;
            _patronymic = patronymic;
            _book = book;
            _number = number;
        }
        public void TakeBook()//взять книгу
        {
            //if (_book == )
            //{
            //     Console.WriteLine($"можете идти");
            //}
            //else if (_book == 0)
            // Console.WriteLine($"");

        }
        public void TakeBook(string name, string surname, string patronymic, int book, string number)
        {
            Console.WriteLine($"{name}.{surname}.{patronymic}. взял: {book} книг");
            _book = book;
        }
        public void Get(Reader reader1)
        {
            info.Add(reader1);
        }

        public void ReturnBook(string surname)//вернуть книгу
        {
            foreach (Reader reader in info)
            {
                if (_surname == surname)
                {
                    info.Remove(reader);
                    return;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"нет такой фамилии");
                    Console.WriteLine();
                }
            }
        }
        public void GetInfo()
        {
            foreach (Reader read in info)
            {
                Console.WriteLine($"{read}");
                //Console.WriteLine();
                //Console.WriteLine($"Имя: {_name}");
                //Console.WriteLine($"Фамилия: {_surname}");
                //Console.WriteLine($"Отчества {_patronymic}");
                //Console.WriteLine($"Количество взятых книг: {_book}");
                //Console.WriteLine($"Номер телефона: {_number}");
                //Console.WriteLine();
            }
                
        }


    }
}
