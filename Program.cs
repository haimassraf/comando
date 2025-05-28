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
            Weapon newWeapon = game1.CreateWeapon("ak47", "kalatchnikov", 5);
            Enemy newEnemy = game1.CreateEnemy("blah blag");
            newSeaComando.Attack();
            newSeaComando.Sweaming();
            newAirCommando.parachuting();
            newEnemy.Yell();
            for (int i = 0; i < 7; i++)
            {
                newWeapon.Shoot();
            }
        }
    }
}
