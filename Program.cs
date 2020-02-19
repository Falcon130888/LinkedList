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
                Console.Write("1 - добавить в конец, 2 - добавить в начало, 3 - удалить по имени, 4 - выбрать по индексу, 0 - для выхода: ");
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
                        var asd = linkedList.Where( q => q.hea)
                        linkedList.Remove(Console.ReadLine());
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
