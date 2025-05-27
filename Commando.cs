using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comando
{
    class Commando
    {
        protected string Name;
        protected string CodeName;
        protected Tools[] ComanderTools;
        protected Status status;


        public string GetName() => this.Name;
        public string GetCodeName() => this.CodeName;
        public string SetCodeName(string newCodeName) => this.CodeName = newCodeName;

        public void Walk()
        {
            this.status = Status.Walk;
            Console.WriteLine($"Solder with code name {this.CodeName} now {this.status}.");
        }

        public void Hide()
        {
            this.status = Status.Hide;
            Console.WriteLine($"Solder with code name {this.CodeName} now {this.status}.");
        }

        public virtual void Attack()
        {
            this.status = Status.Attack;
            Console.WriteLine($"Commander with code name {this.CodeName} now Attacking.");
        }

        public string SayName(string commanderRank)
        {
            if (commanderRank.ToUpper() == "GENERAL")
            {
                return this.Name;
            }
            if (commanderRank.ToUpper() == "COLONEL")
            {
                return this.CodeName;
            }
            Console.WriteLine("You can`t get the information.");
            return null;
        }

        public Commando(string name, string nameCode, Status status)
        {
            this.Name = name;
            this.CodeName = nameCode;
            this.status = status;
            this.ComanderTools = new Tools[] { Tools.hammer, Tools.bag, Tools.rope, Tools.chisel, Tools.watery };
            ComandorFactory.AddCommandor(this);
        }
    }
}
