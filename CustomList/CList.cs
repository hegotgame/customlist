using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CList<T> : IList
    {
        private T[] arr = new T[100];
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
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



        public void Add(T v)
        {
            throw new NotImplementedException();
        }

        public void Remove(T v)
        {
            throw new NotImplementedException();
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
