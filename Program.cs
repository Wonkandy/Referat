using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Referat
{
    class Program
    {
        static void Main(string[] args)
        {
            Geschenk g = new Geschenk(100, ";DROP TABLE USERS;--");
            Console.WriteLine(g.getName() + ": " + g.getPreis());
        }
    }
    class Geschenk
    {
        private int preis;
        private string name;

        public Geschenk(int preis, string name)
        {
            this.preis = preis;
            this.name = name;
        }

        public int getPreis()
        {
            return preis;
        }
        public void setPreis(int preis)
        {
            this.preis = preis;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

    }
}
