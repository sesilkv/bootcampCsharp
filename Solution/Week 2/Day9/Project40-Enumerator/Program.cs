using System;
using System.Collections;

class MySequence : IEnumerable
{
    private int[] data = { 1, 2, 3, 4, 5 };

    public IEnumerator GetEnumerator()
    {
        return new MyEnumerator(data);
    }

    private class MyEnumerator : IEnumerator
    {
        private int[] data;
        private int position = -1;

        public MyEnumerator(int[] data)
        {
            this.data = data;
        }

        public object Current
        {
            get
            {
                return data[position];
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < data.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MySequence sequence = new MySequence();

        foreach (int value in sequence)
        {
            Console.WriteLine(value);
        }
    }
}