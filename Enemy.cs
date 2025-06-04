using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comando
{
    internal class Enemy
    {
        private string name;
        private int life;
        private bool isAlive;

        public void Yell() => Console.WriteLine("Im enemy!");

        public Enemy(string name)
        {
            this.name = name;
            this.life = 100;
            this.isAlive = true;
        }
    }
}
