using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comando
{
    internal class Commando
    {
        private string name { get; set; }
        private string nameCode;
        private string[] tools = new string[5];
        private Status status;

        public enum Status
        {
            Walk,
            Hide,
            Attack
        }

        public void Walk()
        {
            if (this.status != Status.Walk)
            {
                this.status = Status.Walk;
                Console.WriteLine($"Solder with code name {this.nameCode} now {this.status}.");
            }
            else
            {
                Console.WriteLine($"Solder with code name {this.nameCode} already {this.status}.");
            }
        }

        public void Hide()
        {
            if (this.status != Status.Hide)
            {
                this.status = Status.Hide;
                Console.WriteLine($"Solder with code name {this.nameCode} now {this.status}.");
            }
            else
            {
                Console.WriteLine($"Solder with code name {this.nameCode} already {this.status}.");
            }
        }

        public void Attack()
        {
            if (this.status != Status.Attack)
            {
                this.status = Status.Attack;
                Console.WriteLine($"Solder with code name {this.nameCode} now {this.status}.");
            }
            else
            {
                Console.WriteLine($"Solder with code name {this.nameCode} already {this.status}.");
            }
        }

        public Commando(string name, string nameCode, Status status)
        {
            this.name = name;
            this.nameCode = nameCode;
            this.status = status;
            this.tools = new string[] { "Tools", "hammer", "chisel", "rope", "bag", "watery" };
        }
    }
}
