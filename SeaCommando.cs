using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comando
{
    class SeaCommando : Commando
    {
        public SeaCommando(string name, string nameCode) : base(name, nameCode) { }
        public void Sweaming() => Console.WriteLine($"The commando whith code name {this.CodeName} know sweaming");
        public override void Attack() => Console.WriteLine($"Sea commando with code name {this.CodeName} now attacking.");
    }
}
