using System.Collections.Generic;
using System.Collections;
using System;

namespace LinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T>  // двусвязный список
    {
        DoublyNode<T> head; // головной/первый элемент
        DoublyNode<T> tail; // последний/хвостовой элемент
        int count;  // количество элементов в списке

        // добавление элемента
        public void AddLast(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);

            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }
        public void AddFirst(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            DoublyNode<T> temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.Previous = node;
            count++;
        }
        // Добавление по индексу
        public bool AddById(int index, T newElement)
        {
            int i = 0;
            DoublyNode<T> current = head;
            // поиск индекса узла
            while (current != null)
            {
                if (i == index)
                {
                    break;
                }
                current = current.Next;
                i++;
            }
            if (current != null)
            {
                if (current.Previous == null)
                {
                    AddFirst(newElement);
                }
                else if (current.Next == null)
                {
                    AddLast(newElement);
                }
                else
                {
                    DoublyNode<T> newNode = new DoublyNode<T>(newElement); //создаем объект
                    current.Previous.Next = newNode;
                    newNode.Previous = current.Previous;
                    current.Previous = newNode;
                    newNode.Next = current;
                }
                count++;
                return true;
            }
            return false;
        }
        // удаление по индексу
        public bool RemoveById(int index)
        {
            int i = 0;
            DoublyNode<T> current = head;

            // поиск удаляемого узла
            while (current != null)
            {
                if (i == index)
                {
                    break;
                }
                current = current.Next;
                i++;
            }
            if (current != null)
            {
                // если узел не последний
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    // если последний, переустанавливаем tail
                    tail = current.Previous;
                }

                // если узел не первый
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    // если первый, переустанавливаем head
                    head = current.Next;
                }
                count--;
                return true;
            }
            return false;
        }
        // удаление
        public bool Remove(T data)
        {
            DoublyNode<T> current = head;

            // поиск удаляемого узла
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }
                current = current.Next;
            }
            if (current != null)
            {
                // если узел не последний
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    // если последний, переустанавливаем tail
                    tail = current.Previous;
                }

                // если узел не первый
                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    // если первый, переустанавливаем head
                    head = current.Next;
                }
                count--;
                return true;
            }
            return false;
        }

        // пузырьковая сортировка списка
        public void BubbleSort()
        {
            DoublyNode<T> current, index;
            T temp;
            //проверяем наличие элементов
            if (head == null)
            {
                return;
            }
            else
            {
                //Начинаем с головного элемента
                for (current = head; current.Next != null; current = current.Next)
                {
                    //Index will point to node next to current  
                    for (index = current.Next; index != null; index = index.Next)
                    {
                        //If current's data is greater than index's data, swap the data of current and index  
                        if (current.Data.ToString().CompareTo(index.Data.ToString()) > 0)
                        {
                            temp = current.Data;
                            current.Data = index.Data;
                            index.Data = temp;
                        }
                    }
                }
            }
        }
        public int Count { get { return count; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public T  GetByIndex(int index)
        {
            int i = 0;
            if (index < this.Count - 1)
            {
                foreach (var item in this)
                {
                    if (i == index)return item;
                    i++;
                }
            }
            else
            {
                Console.Write("индекс превышает размер списка\n");
            }
            return default;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}