using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

//Добавьте к уже созданному классу информацию о площади магазина.
//Выполните перегрузку + (для увеличения площади магазина на указанную 
//величину), — (для уменьшения площади магазина на 
//указанную величину), == (проверка на равенство площадей магазинов), < и > (проверка на меньше или больше 
//площади магазина), != и Equals.Используйте механизм свойств для полей класса.

namespace Task_2
{
    internal class Shop
    {
        public string name;
        public string adres;
        public string comments;
        public string phone;
        public string email;
        public int square;

        public Shop() { }
        public Shop(string name, string adres, string comments, string phone, string email, int square)
        {
            this.name = name;
            this.adres = adres;
            this.comments = comments;
            this.phone = phone;
            this.email = email;
            this.square = square;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value == " " || value.Length == 0)
                {
                    throw new Exception("Ошибка: Пустая строка, или пробел!");
                }
                name = value;
            }
        }
        public string Adres
        {
            get { return adres; }
            set
            {
                if (value == " " || value.Length == 0)
                {
                    throw new Exception("Ошибка: Пустая строка, или пробел!");
                }
                adres = value;
            }
        }
        public string Comments
        {
            get { return comments; }
            set
            {
                if (value == " " || value.Length == 0)
                {
                    throw new Exception("Ошибка: Пустая строка, или пробел!");
                }
                comments = value;
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                if (value == " " || value.Length == 0)
                {
                    throw new Exception("Ошибка: Пустая строка, или пробел!");
                }
                phone = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (value == " " || value.Length == 0)
                {
                    throw new Exception("Ошибка: Пустая строка, или пробел!");
                }
                email = value;
            }
        }
        public int Square
        {
            get { return square; }
            set { square = value; }
        }

        public override string ToString()
        {
            return $"\nНазвание магазина: {name}\n\tАдрес: {adres}\n\t" +
                $"Описание: {comments}\n\tКонтактный телефон: {phone}\n\tКонтактный e-mail: {email}\n\tПлощадь магазина: {square} м2\n";
        }
        public void Input()
        {
            Console.WriteLine("Введите название магазина: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите адрес магазина: ");
            Adres = Console.ReadLine();
            Console.WriteLine("Введите описание магазина: ");
            Comments = Console.ReadLine();
            Console.WriteLine("Введите контактный телефон магазина: ");
            Phone = Console.ReadLine();
            Console.WriteLine("Введите контактный e-mail магазина: ");
            Email = Console.ReadLine();
            Console.WriteLine("Введите площадь магазина: ");
            Square = Convert.ToInt32(Console.ReadLine());
        }

        //перегрузка + (для увеличения площади магазина на указанную величину)
        public static Shop operator +(Shop obj, int a)
        {
            obj.square += a;
            return obj;
        }

        //перегрузка - (для уменьшения площади магазина на указанную величину)
        public static Shop operator -(Shop obj, int a)
        {
            if (obj.square < a)
            {
                throw new Exception("Ошибка при отнимании площади!!! Площадь магазина < указанное число");
            }
            obj.square -= a;
            return obj;
        }

        //перегрузка ++
        public static Shop operator ++(Shop obj)
        {
            obj.square++;
            return obj;
        }

        //перегрузка == (проверка на равенство площадей магазинов)
        public static bool operator ==(Shop a, Shop b)
        {
            return a.square == b.square;
        }
        public static bool operator !=(Shop a, Shop b)
        {
            return a.square != b.square;
        }

        //перегрузка < и > (проверка на меньше или больше площади магазина)
        public static bool operator <(Shop a, Shop b)
        {
            return a.square < b.square;
        }
        public static bool operator >(Shop a, Shop b)
        {
            return a.square > b.square;
        }

        //перегрузка Equals
        public override bool Equals(object obj)
        {
            if (obj is Shop)
            {
                Shop j = obj as Shop ;
                if (this.name == j.name && this.adres == j.adres && this.comments == j.comments
                    && this.phone == j.phone && this.email == j.email && this.square == j.square)
                    return true;
                else
                    return false;
            }
            throw new Exception("Тип != Shop");
        }
    }
}
