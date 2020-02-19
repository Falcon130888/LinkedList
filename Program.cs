using System;
using System.Linq;

namespace LinkedList
{
    class Program
    {
        static void Main()
        {
            DoublyLinkedList<string> linkedList = new DoublyLinkedList<string>();
            // добавление элементов
            linkedList.AddLast("Bob");
            linkedList.AddLast("Bill");
            linkedList.AddLast("Tom");
            linkedList.AddFirst("Kate");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            String str;
            do
            {
                Console.Write("Выберите действие:\n 1 - добавить в конец \n 2 - добавить в начало \n" +
                    " 3 - удалить по имени \n 4 - удалить по индексу \n 0 - для выхода: ");
                 str = Console.ReadLine();
                switch (str)
                {
                    case "1":
                        Console.Write("введите значение: ");
                        linkedList.AddLast(Console.ReadLine());
                        break;
                    case "2":
                        Console.Write("введите значение: ");
                        linkedList.AddFirst(Console.ReadLine());
                        break;
                    case "3":
                        Console.Write("введите значение: ");
                        linkedList.Remove(Console.ReadLine());
                        break;
                    case "4":
                        Console.Write("введите индекс: ");
                        try
                        {
                            int index = Convert.ToInt32(Console.ReadLine());
                            linkedList.RemoveById(index);
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
                            Console.Write("введите значение: ");
                            String value = Console.ReadLine();
                            linkedList.AddById(index, value);
                        }
                        catch
                        {
                            Console.Write("ОШИБКА! \n");
                        }
                        break;
                    case "0":
                        return;
                }
                    foreach (var item in linkedList)
                    {
                        Console.WriteLine(item);
                    }
            } while (str != "0");

            // перебор с последнего элемента
            //foreach (var t in linkedList.BackEnumerator())
            //{
            //    Console.WriteLine(t);
            //}

        }
    }
}
