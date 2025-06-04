using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comando
{
    class AirCommando : Commando
    {
        public AirCommando(string name, string nameCode) : base(name, nameCode) { }

        public void parachuting() => Console.WriteLine($"The commando with code name {this.CodeName} know parachuting.");
        public override void Attack() => Console.WriteLine($"Air commando with code name {this.CodeName} now attacking.");
    }
}
