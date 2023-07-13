//Задание 1
//Ранее в одном из практических заданий вы создавали 
//класс «Журнал». Добавьте к уже созданному классу информацию о количестве сотрудников. Выполните перегрузку 
//+ (для увеличения количества сотрудников на указанную 
//величину), — (для уменьшения количества сотрудников 
//на указанную величину), == (проверка на равенство количества сотрудников), < и > (проверка на меньше или 
//больше количества сотрудников), != и Equals.Используйте
//механизм свойств для полей класса.

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Journal jour = new Journal();
            //try
            //{
            //    jour.Input();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine($"\n{jour}\n");

            #region использование класса Журнал

            Journal jour1 = new Journal("Forbes",2010,"Bysiness and its life","+15453245456","forbes@gmail.com",20);
            Journal jour2 = new Journal("Forbes", 2010, "Bysiness and its life", "+15453245456", "forbes@gmail.com", 20);
            Journal jour3 = new Journal("Day of the week", 2010, "Buildings and all about", "+15455678845", "dayoftheweek@gmail.com", 20);
            Console.WriteLine(jour1);
            Console.WriteLine(jour2);
            Console.WriteLine(jour3);
            try
            {
                //увеличение количества сотрудников на указанную величину
                jour3 = jour3 + 5;
                Console.WriteLine($"\nДобавили сотрудников: { jour3}");
                // уменьшение количества сотрудников на указанную величину
                jour3 = jour3 - 20;
                Console.WriteLine($"\nУбрали сотрудников: {jour3}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // операции: ==, !=, <, >
            if (jour1 == jour3)
                Console.WriteLine("Кол-во сотрудников объектов Равно");
            if (jour1 != jour3)
                Console.WriteLine("Кол-во сотрудников объектов НЕ равно");
            if (jour1 > jour3)
                Console.WriteLine($"Кол-во сотрудников журнала {jour1.Name} Больше кол-ва сотрудников журнала {jour3.Name}");
            else if (jour1 < jour3)
                Console.WriteLine($"Кол-во сотрудников журнала {jour1.Name} Меньше кол-ва сотрудников журнала {jour3.Name}");
            else
                Console.WriteLine("Кол-во сотрудников обеих журналов Равно");
            try
            {
                if (jour1.Equals(jour2))
                    Console.WriteLine("Объекты Равны");
                else
                    Console.WriteLine("Объекты НЕ равны");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            #endregion
        }

    }
}