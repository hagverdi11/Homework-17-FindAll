using System;
using System.Collections.Generic;
using System.Text;

namespace FindAll.Models
{
    public class MyList <T>
    {
        private T[] _arr;
        public int Count { get; set; }

        public MyList()
        {
            _arr = new T[10];
        }

        public void Add (T data)
        {
            if (Count != 0 && Count % 10 == 0)
            {
                Array.Resize(ref _arr, _arr.Length + 10);
            }
            _arr[Count] = data;
            Count++;
        }

        public void GetAll()
        {
            foreach (var item in _arr)
            {
                Console.WriteLine(item);

            }
        }

        public void Clear()
        {
            _arr = new T[10];
        }


        public T Find (Predicate<T> predicate)
        {
            foreach (var item in _arr)
            {
                if (predicate(item))
                {
                    return item;
                }

            }
            return default;
        }


        public T FindAll(Predicate<T> predicate)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (predicate(_arr[i]))
                {
                    Console.WriteLine(_arr[i]);
                }
            }
            return default;
        }
    }
}
