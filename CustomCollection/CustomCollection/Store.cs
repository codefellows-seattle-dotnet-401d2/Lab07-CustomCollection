using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomCollection
{
    public class Store<T> : IEnumerable<T>
    {
        public T[] items = new T[10];
        public int count = 0;

        /// <summary>
        /// Add an item to the collection. Also determines if collection array is getting full and increases by 50% if it gets more than 70% full.
        /// </summary>
        /// <param name="item">Object to add to collection</param>
        public void Add(T item)
        {
            Console.WriteLine("Collection size before add: " + items.Length);
            Console.WriteLine("Property Count: " + count);
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

        /// <summary>
        /// Remove an item from the collection. Does this by shifting all items after the passed in object to the left by 1. Also checks beforehand if the collection array is less than 30% capacity, and shrinks by 50% if so.
        /// </summary>
        /// <param name="item">Object to remove from collection.</param>
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
                        // if not, start at i (location of item to remove) and move everything over by 1.
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

        /// <summary>
        /// Simply retrieves an item from the collection at a specific index and returns that index location.
        /// </summary>
        /// <param name="index">index to grab object from.</param>
        /// <returns>The index location of the object.</returns>
        public int GetAtIndex(T item)
        {
            int index = 0;
            for (int i = 0; i < count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(items[i], item))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        
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
