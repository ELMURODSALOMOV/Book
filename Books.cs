using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Books
    {
        public Books(string name)
        {
            this.name = name;
        }

        private string name;
        private string author;
        private int cost;
        private int soni;
        private bool read;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public int Soni
        {
            get { return soni; }
            set { soni = value; }
        }
        public bool Read
        {
            get { return read; }
            set { read = value; }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Book name: {name}");
            Console.WriteLine($"Book author: {author}");
            Console.WriteLine($"Book cost: {cost}");
        }
    }
}
