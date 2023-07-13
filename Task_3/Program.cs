//Задание 3
//Создайте приложение «Список книг для прочтения». 
//Приложение должно позволять добавлять книги в список, удалять книги из списка, проверять есть ли книга в 
//списке, и т. д. Используйте механизм свойств, перегрузки 
//операторов, индексаторов.

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListBooks list = new ListBooks();
            list = list + new Book("Sql", "Autor1", 2021);
            list = list + new Book("C++", "Autor2", 2006);
            list = list + new Book("Ado.net", "Autor3", 2010);
            list = list + new Book("C#", "Autor4", 2012);

            for (int i=0; i<list.books.Count;i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("\n");

            list = list - new Book("Ado.net", "Autor3", 2010);

            foreach (var a in list.books)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("\n");

            if (list.Find(new Book("Sql", "Autor1", 2021)))
                Console.WriteLine("Книга найдена!!!");
            else 
                Console.WriteLine("Книги нет!!!");
        }
    }
}