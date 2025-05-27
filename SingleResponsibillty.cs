using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comando
{
    internal class SingleResponsibillty
    {
        private string name;
        private int life;
        private bool isAlive;

        public void Yell() => Console.WriteLine("Im enemy!");

        public SingleResponsibillty(string name)
        {
            this.name = name;
            this.life = 100;
            this.isAlive = true;
        }
    }
}
