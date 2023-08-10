using System.Collections;
using System;
class Program
{
    static void Main(string[] args)
    {
        MyNumerable myNumerable = new();
        foreach (string _name in myNumerable)
        {
            Console.WriteLine(_name);
        }
    }
}
class MyNumerable : IEnumerable
{
    private string[] _name = { "Ryu", "Ken", "Guile", "Chun-Li", };

    public IEnumerator GetEnumerator()
    {
        return new MyEnumerator(_name);
    }

    private class MyEnumerator : IEnumerator
    {
        private string[] data;
        private int position = -1;

        public MyEnumerator(string[] data)
        {
            this.data = data;
        }

        public object Current
        {
            get { return data[position]; }
        }

        public bool MoveNext()
        {
            position++;
            return(position < data.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }

}