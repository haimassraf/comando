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
            Game game1 = new Game();
            SeaCommando newSeaComando = (SeaCommando)game1.CreateComandor("haim", "sea king", CommandoType.SeaCommando);
            AirCommando newAirCommando = (AirCommando)game1.CreateComandor("haim", "air king", CommandoType.AirCommando);
            Weapon weapon1 = game1.CreateWeapon("AK47", "KALASHNIKOV", 30);
            Weapon weapon2 = game1.CreateWeapon("M16", "COLT", 29);
            Enemy newEnemy = game1.CreateEnemy("blah blah");
            newSeaComando.Attack();
            newSeaComando.Sweaming();
            newAirCommando.parachuting();
            newEnemy.Yell();
        }
    }
}
