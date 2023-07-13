//Задание 2
//Ранее в одном из практических заданий вы создавали класс «Магазин». Добавьте к уже созданному классу 
//информацию о площади магазина. Выполните перегрузку + (для увеличения площади магазина на указанную 
//величину), — (для уменьшения площади магазина на 
//указанную величину), == (проверка на равенство площадей магазинов), < и > (проверка на меньше или больше 
//площади магазина), != и Equals.Используйте механизм свойств для полей класса.


namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Shop newshop = new Shop();
            //    try
            //    {
            //        newshop.Input();
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    Console.WriteLine($"\n{newshop}\n");

            #region использование класса Магазин

            Shop s1 = new Shop("Fish and Meat", "New Street 8", "Always fresh and chip", "+15453245456", "fishandmeat@gmail.com", 100);
            Shop s2 = new Shop("Fish and Meat", "New Street 8", "Always fresh and chip", "+15453245456", "fishandmeat@gmail.com", 100);
            Shop s3 = new Shop("China Goods", "Beverly Hills 10", "Best quality china goods", "+15455678845", "chinagoods@gmail.com", 120);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            try
            {
                //увеличение количества сотрудников на указанную величину
                s3 = s3 + 50;
                Console.WriteLine($"\nДобавили площадь: {s3}");
                // уменьшение количества сотрудников на указанную величину
                s3 = s3 - 100;
                Console.WriteLine($"\nУбавили площадь: {s3}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // операции: ==, !=, <, >
            if (s1 == s3)
                Console.WriteLine("Площадь объектов Равна");
            if (s1 != s3)
                Console.WriteLine("Площадь объектов НЕ равна");
            if (s1 > s3)
                Console.WriteLine($"Площадь магазина {s1.Name} Больше площади магазина {s3.Name}");
            else if (s1 < s3)
                Console.WriteLine($"Площадь магазина {s1.Name} Меньше площади магазина {s3.Name}");
            else
                Console.WriteLine("Площади обеих магазинов Равны");
            try
            {
                if (s1.Equals(s2))
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