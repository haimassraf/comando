using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comando
{
    class AirCommando : Commando
    {
        public AirCommando(string name, string nameCode, Status status) : base(name, nameCode, status) { }

        public void parachuting() => Console.WriteLine("The commandor know parachuting.");
        public override void Attack() => Console.WriteLine($"Air solder with code name {this.CodeName} now attacking.");
    }

    class SeaCommando : Commando
    {
        public SeaCommando(string name, string nameCode, Status status) : base(name, nameCode, status) { }

        public void Sweaming() => Console.WriteLine("The commandor know sweaming");
        public override void Attack() => Console.WriteLine($"Sea commandor with code name {this.CodeName} now attacking.");
    }
}
