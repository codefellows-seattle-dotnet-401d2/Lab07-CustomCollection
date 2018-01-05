using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomCollection
{
    class Store<T> : IEnumerable<T>
    {
        T[] items = new T[10];
        int count = 0;

        public void Add(T item)
        {
            Console.WriteLine("Collection size before add: " + items.Length);
            Console.WriteLine("Property Count: " + count);
            // if (count == (items.Length / 2))
            if (count > (int)Math.Ceiling((items.Length * 0.7)))
            {
                Console.WriteLine("Array > 70% capacity! Increasing array size by 50%!");
                T[] newArray = new T[(int)Math.Ceiling((items.Length * 1.5))];
                for (int i = 0; i < items.Length; i++)
                {
                    newArray[i] = items[i];
                }
                items = newArray;
            }
            items[count] = item;
            count++;
            Console.WriteLine("Collection size after add: " + items.Length);
            Console.WriteLine("Property Count: " + count);
            Console.WriteLine("");
        }

        public void Remove(T item)
        {
            Console.WriteLine("Collection size before remove: " + items.Length);
            Console.WriteLine("Property Count: " + count);
            for (int i=0; i < items.Length; i++)
            {
                if(EqualityComparer<T>.Default.Equals(items[i], item))
                {
                    Console.WriteLine("Found item at index " + i + " during remove method.");
                    // check if size is a quarter full and should shrink by 1/2
                    if (count < (int)Math.Ceiling((items.Length * 0.3)))
                    {
                        // if so create new array 1/2 size to transfer contents without item trying to remove.
                        Console.WriteLine("Array < 30% capacity! Decreasing array size by 50%!");
                        T[] newArray = new T[(int)Math.Ceiling((items.Length * 0.5))];
                        int temp = 0;
                        for (int k = 0; k < newArray.Length - 1; k++)
                        {
                            if (k == i) temp++;
                            newArray[k] = items[temp];
                            temp++;
                        }
                        items = newArray;
                    }
                    else
                    {
                        // if not, start at i and move everything over.
                        Console.WriteLine("Removing item by shifting everything after it over by one!");
                        int temp = i + 1;
                        for (int k = i; k < items.Length - 1; k++)
                        {
                            items[k] = items[temp];
                            temp++;
                        }
                    }
                    count--;
                    break;
                }
            }
            Console.WriteLine("Collection size after remove: " + items.Length);
            Console.WriteLine("Property Count: " + count);
            Console.WriteLine("");
        }

        public void ViewAll()
        {
            Console.WriteLine("All items currently in the collection: ");
            foreach(T item in items)
            {
                if(item != null)
                {
                    Console.WriteLine(item);
                }
            }
        }
        /*
        public T GetAtIndex(int index)
        {
            return ;
        }
        */
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //Magic don't touch.
            return GetEnumerator();
        }
    }
}
