using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
        public class CList<T> : ICList
        {
            private int count;
            private int capacity;
            public int Count { get { return count; } }
            public int Capacity { get { return capacity; } set { capacity = value; } }

            public CList()
            {
                count = 0;
                capacity = 4;
                baseArray = new T[capacity];
            }

        private T[] baseArray;
        public T this[int i]
        {
            get { return baseArray[i]; }
            set { baseArray[i] = value; }
        }

        public void Add(T v)
        {
            if (count >= capacity)
            {
                T[] nextArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    nextArray[i] = baseArray[i];
                }
                baseArray = nextArray;
                baseArray[count] = v;
                count++;
            }
            else
            {
                baseArray[count] = v;
                count++;
            }
        }

        public void Remove(T v)
        {
            for (int i = 0; i < count; i++)
            {
                if (baseArray[i].Equals(v))
                {
                    count--;
                    for (int j = i; j < count; j++)
                    {
                        baseArray[j] = baseArray[j + 1];
                    }
                    baseArray[count + 1] = default(T);
                }
            }
        }

        public void ToString (T v)
        {

        }
        public override string ToString()

        {

            string resultString = "";

            if (count != 0)

                for (int i = 0; i < count; i++)

                    resultString = ConvertValuesToString();
            return resultString;
        }

        private string ConvertValuesToString()
        {
            string initialString = "";
            for (int i = 0; i < count; i++)
            {
                initialString += baseArray[i];
            }
            return initialString;
        }

        public static CList<T> operator +(CList<T> a, CList<T> b)
        {
            CList<T> result = new CList<T> { };
            for (int i = 0; i < a.count; i++)
            {
                result[i] = a[i] + b[i];
            }
        }

        public static CList<T> operator -(CList<T> a, CList<T> b)
        {
            CList<T> result = new CList<T> { };
            for (int i = 0; i < a.count; i++)
            {
                result[i] = a[i] - b[i];
            }
        }

        public void Zip (T[] l, T[] m)
        {
            T[] i = { };
            T[] j = { };
            T[] k = { };

            /*
            int[] numbers = { 1, 2, 3, 4 };
            string[] words = { "one", "two", "three" };

            var numbersAndWords = numbers.Zip(words, (first, second) => first + " " + second);

            foreach (var item in numbersAndWords)
                Console.WriteLine(item);

            // This code produces the following output:

            // 1 one
            // 2 two
            // 3 three
            */

        }

        public void Sort (T v)
        {

        }

        public void Add(IEnumerable<string> numbersANDwords)
        {
            throw new NotImplementedException();
        }
/*
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(
        this IEnumerable<TFirst> first,
        IEnumerable<TSecond> second,
        Func<TFirst, TSecond, TResult> resultSelector
        )
        { }
*/
    }
}
