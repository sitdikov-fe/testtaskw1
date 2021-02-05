using System;

namespace Task1
{

    public sealed class Item
    {
        private int id;
        private string name;
        private int status;
        private bool changed;


        public Item(int n) { id = n; }

        private bool _InitExecuted = false;

        private void Init()
        {
            if (_InitExecuted)
                return;

            _InitExecuted = true;

            Console.WriteLine($"Имя: {name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
