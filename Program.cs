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
            newCommando.Walk();
            newCommando.Attack();
            newCommando.Walk();

            Weapon newWeapon = new Weapon("ak47", "israel", 3);
            for (int i = 0; i < 4; i++)
            {
                newWeapon.Shoot();
            }
        }
    }
}
