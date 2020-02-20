using System;
using System.Linq;

namespace LinkedList
{
    class Program
    {
        static void Main()
        {
            DoublyLinkedList<string> LinkedList = new DoublyLinkedList<string>();
            // добавление элементов
            LinkedList.AddLast("Bob");
            LinkedList.AddLast("Bill");
            LinkedList.AddLast("Tom");
            LinkedList.AddLast("Stas");
            LinkedList.AddLast("Viktor");
            LinkedList.AddFirst("Kate");

            foreach (var item in LinkedList)
            {
                Console.WriteLine(item);
            }
            String str;
            do
            {
                Console.Write("Выберите действие:\n 1 - добавить в конец \n 2 - добавить в начало \n" +
                    " 3 - добавить по индексу \n 4 - удалить по индексу \n 5 - получение элемента по индексу \n" +
                    " 6 - узнать количество элементов в списке \n 7 - сортировать список \n 0 - для выхода \n ");
                 str = Console.ReadLine();
                switch (str)
                {
                    case "1":
                        Console.Write("введите значение: ");
                        LinkedList.AddLast(Console.ReadLine());
                        break;
                    case "2":
                        Console.Write("введите значение: ");
                        LinkedList.AddFirst(Console.ReadLine());
                        break;
                    case "3":
                        try
                        {
                            Console.Write("введите индекс: ");
                            int index = Convert.ToInt32(Console.ReadLine());
                            Console.Write("введите значение: ");
                            String value = Console.ReadLine();
                            LinkedList.AddById(index, value);
                        }
                        catch
                        {
                            Console.Write("ОШИБКА! \n");
                        }
                        break;
                    case "4":
                        Console.Write("введите индекс: ");
                        try
                        {
                            int index = Convert.ToInt32(Console.ReadLine());
                            LinkedList.RemoveById(index);
                        }
                        catch
                        {
                            Console.Write("ОШИБКА! \n");
                        }
                        break;
                    case "5":

                        try
                        {
                            Console.Write("введите индекс: ");
                            int index = Convert.ToInt32(Console.ReadLine());
                            var result = LinkedList.GetByIndex(index);
                            if( result != null) Console.WriteLine("Значение по индексу: {0} \n", result);
                        }
                        catch
                        {
                            Console.Write("ОШИБКА! \n");
                        }
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Write("всего элементов в списке: {0} \n", LinkedList.Count());
                        Console.ReadKey();
                        break;
                    case "7":
                        LinkedList.BubbleSort();
                        break;
                    case "0":
                        return;
                }
                    foreach (var item in LinkedList)
                    {
                        Console.WriteLine(item);
                    }
            } while (str != "0");
        }
    }
}
