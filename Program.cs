using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando newCommando = new Commando("haim", "245", Commando.Status.Walk);
            AirCommando airCommando = new AirCommando("haim", "666", Commando.Status.Hide);
            SeaCommando seaCommando = new SeaCommando("haim", "555", Commando.Status.Attack);
            Commando[] comandosArr = new Commando[] { newCommando, airCommando, seaCommando };
            foreach(Commando solder in comandosArr)
            {
                solder.Attack();
            }

            Weapon newWeapon = new Weapon("ak47", "israel", 3);
        }
    }
}
